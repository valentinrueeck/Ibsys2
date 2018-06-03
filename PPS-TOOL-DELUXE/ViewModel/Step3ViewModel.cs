using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.Model;
using PPS_TOOL_DELUXE.Model.MasterData.ProduceItems;
using PPS_TOOL_DELUXE.Model.MasterData.PurchaseItems;
using PPS_TOOL_DELUXE.Model.Output;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class Step3ViewModel : ViewModelBase
    {
        public Action CloseAction { get; set; }
        public Action ShowNextAction { get; set; }

        public static List<purchaseItemsItem> ListOfPurchaseItems { get; private set; }
        private results rLastPeriod;
        private List<resultsWarehousestockArticle> articleList;
        private ExportModel exportModel;
        public List<Order> Purchaseorders { get; } = new List<Order>();

        public ObservableCollection<string> KindOfDeliveryOptions { get; set; } = new ObservableCollection<string> { "N", "E" };

        public ObservableCollection<PurchaseModel> PurchaseModels { get; } = new ObservableCollection<PurchaseModel>();

        public Step3ViewModel()
        {
            NextCommand = new RelayCommand(NextClick);
        }

        public void Initialize()
        {
            rLastPeriod = ServiceLocator.Current.GetInstance<DashboardViewModel>().LastPeriod;
            exportModel = ServiceLocator.Current.GetInstance<MainViewModel>().export;
            articleList = rLastPeriod.warehousestock.article.ToList();

            ListOfPurchaseItems = PurchaseItemsModel.GetInstance().GetPurchaseItems();

            addRows();
        }

        private void addRows()
        {
            var mapOfPurchaseItems = new Dictionary<int, int>();
            exportModel.productionList.ForEach(productionItem =>
            {
                produceItemsItem produceItem = getItemFromProduceItemList(productionItem.article);
                produceItem.subComponentList.ToList().ForEach(subComponent =>
                {
                    if (subComponent.typ.Equals("K"))
                    {
                        var amount = 0;
                        if (!mapOfPurchaseItems.TryGetValue(subComponent.id, out amount))
                            mapOfPurchaseItems.Add(subComponent.id, subComponent.need * productionItem.quantity);
                        else
                            mapOfPurchaseItems[subComponent.id] =
                                amount + subComponent.need * productionItem.quantity;
                    }
                });
            });

            ListOfPurchaseItems.ForEach(item =>
            {
                var itemNumber = item.id;

                double normalDeliveryDate = item.deliveryTime;
                double latestDeliveryDate = item.deliveryTime + item.deliveryTimeVariance;
                latestDeliveryDate = Math.Floor(latestDeliveryDate * 10) / 10;

                var hurryUpDeliverydate = item.deliveryTime / 2;
                resultsWarehousestockArticle articleFromResults = getArticleFromResults(itemNumber);
                double existingStockValue = -1;
                if (articleFromResults != null)
                {
                    var article = articleFromResults;
                    existingStockValue = article.amount;
                }

                int usageT0 = mapOfPurchaseItems.ContainsKey(item.id) ? mapOfPurchaseItems[item.id] : -1;
                int usageT1 = 0;
                int usageT2 = 0;
                int usageT3 = 0;

                if (usageT0 == -1)
                {
                    usageT0 = 0;
                }

                usageT1 = calculateForecastUsage(itemNumber, 1);
                if (usageT1 < 0)
                {
                    usageT1 = 0;
                }

                usageT2 = calculateForecastUsage(itemNumber, 2);
                if (usageT2 < 0)
                {
                    usageT2 = 0;
                }

                usageT3 = calculateForecastUsage(itemNumber, 3);
                if (usageT3 < 0)
                {
                    usageT3 = 0;
                }

                var tm = new TimeModel(usageT0, usageT1, usageT2, usageT3);

                string openOrders = getOpenOrdersById(item.id, latestDeliveryDate, hurryUpDeliverydate);

                var discontAmount = item.discountAmount;
                var purchaseAmount = 0;

                var purchaseModel = new PurchaseModel(itemNumber, existingStockValue, tm, openOrders,
                    normalDeliveryDate, latestDeliveryDate, hurryUpDeliverydate, discontAmount, purchaseAmount,
                    "");
                purchaseModel = calculateIfOrderIsNecessary(purchaseModel);

                PurchaseModels.Add(purchaseModel);
            });
        }

        private resultsWarehousestockArticle getArticleFromResults(int id)
        {
            return articleList.FirstOrDefault(a => a.id == id);
        }

        private int calculateForecastUsage(int purchaseItemId, int periodNumber)
        {
            List<Forecast> forecastsMatchingPeriod = getForecastsByPeriod(periodNumber);
            int amount = 0;

            int amount1 = isInProduct(purchaseItemId, getItemFromProduceItemList(1));
            int amount2 = isInProduct(purchaseItemId, getItemFromProduceItemList(2));
            int amount3 = isInProduct(purchaseItemId, getItemFromProduceItemList(3));

            foreach (Forecast forecast in forecastsMatchingPeriod)
            {
                switch (forecast.itemNumber)
                {
                    case 1:
                        amount += amount1 * forecast.amount;
                        break;
                    case 2:
                        amount += amount2 * forecast.amount;
                        break;
                    case 3:
                        amount += amount3 * forecast.amount;
                        break;
                }
            }

            return amount;
        }

        private List<Forecast> getForecastsByPeriod(int periodNumber)
        {
            var forecastsMatchingPeriod = new List<Forecast>();
            exportModel.forecastList.ForEach(sellwish =>
            {
                if (sellwish.period == periodNumber)
                {
                    forecastsMatchingPeriod.Add(sellwish);
                }
            });
            return forecastsMatchingPeriod;
        }

        private int isInProduct(int itemId, produceItemsItem startItem)
        {
            int needAmount = 0;

            foreach (produceItemsItemSubComponent item in startItem.subComponentList.ToList())
            {
                if (item.id == itemId)
                {
                    needAmount += item.need;
                }

                if (item.typ.Equals("E"))
                {
                    needAmount += isInProduct(itemId, getItemFromProduceItemList(item.id));
                }
            }

            return needAmount;
        }

        private produceItemsItem getItemFromProduceItemList(int itemId)
        {
            foreach (var item in ProduceItemsModel.GetInstance().GetProduceItems())
            {
                if (item.id == itemId)
                {
                    return item;
                }
            }

            return null;
        }

        private string getOpenOrdersById(int id, double latesPossibleArrival, double fastOrderArrival)
        {
            string arrivalDate = "";
            foreach (var order in rLastPeriod.inwardstockmovement.ToList())
            {
                if (order.article == id)
                {
                    double deliverydate =
                        getDeliveryTimeForCurrentPeriod(order, latesPossibleArrival, fastOrderArrival);
                    if (deliverydate < rLastPeriod.period + 1)
                    {
                        deliverydate = rLastPeriod.period + 1.1;
                    }

                    arrivalDate += deliverydate + ": " + order.amount + "\n";
                }
            }

            foreach (var order in rLastPeriod.futureinwardstockmovement.ToList())
            {
                if (order.article == id)
                {
                    arrivalDate += getDeliveryTimeForFuture(order, latesPossibleArrival, fastOrderArrival) + ": " +
                                   order.amount + "\n";
                }
            }

            return arrivalDate;
        }
        private double getDeliveryTimeForFuture(resultsOrder1 order,
            double latesPossibleArrival, double fastOrderArrival)
        {

            if (order.mode == 4)
            {
                return order.orderperiod + fastOrderArrival;
            }

            return order.orderperiod+ latesPossibleArrival;
        }

        private double getDeliveryTimeForCurrentPeriod(resultsOrder order,
            double latesPossibleArrival, double fastOrderArrival)
        {

            if (order.mode == 4)
            {
                return order.orderperiod + fastOrderArrival;
            }

            return order.orderperiod + latesPossibleArrival;
        }

        private PurchaseModel calculateIfOrderIsNecessary(PurchaseModel purchase)
        {
            if (purchase == null)
            {
                return null;
            }

            string[] orders = purchase.OpenOrders.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            double checkValue = 0;
            bool orderWithEil = false;
            int stock = (int) purchase.StockValue;
            double latesPossibleArrival = purchase.LatestDeliveryDate;
            int t0 = purchase.Timemodel.T0;
            int t1 = purchase.Timemodel.T1;
            int t2 = purchase.Timemodel.T2;
            int t3 = purchase.Timemodel.T3;
            double arrivalOrderTime = 0;
            double stock0 = stock - t0;
            double stock1 = stock - t0 - t1;
            double stock2 = stock - t0 - t1 - t2;

            foreach (var t in orders)
            {
                if (!string.IsNullOrEmpty(t))
                {
                    String[] order = t.Split(':');
                    arrivalOrderTime = Double.Parse(order[0]) - rLastPeriod.period;
                    double threshold = 0.8;
                    arrivalOrderTime = Math.Round(arrivalOrderTime - threshold + 0.5);
                    if (arrivalOrderTime < 2)
                    {
                        stock0 += Math.Floor(Double.Parse(order[1]));
                    }
                    else if (arrivalOrderTime < 3)
                    {
                        stock1 += Math.Floor(Double.Parse(order[1]));
                    }
                    else if (arrivalOrderTime < 4)
                    {
                        stock2 += Math.Floor(Double.Parse(order[1]));
                    }
                }
            }

            if (latesPossibleArrival < 1.2)
            {
                checkValue = stock - t0;
                if (checkValue <= 0)
                {
                    orderWithEil = true;
                }
            }
            else if (latesPossibleArrival < 2.2)
            {
                if ((stock0 <= 0 || stock0 < t1))
                {
                    orderWithEil = true;
                }
                checkValue = stock1;
            }
            else if (latesPossibleArrival < 3.2)
            {
                if ((stock0 <= 0 || stock1 < 0 || stock0 < t1 || stock1 < t2))
                {
                    orderWithEil = true;
                }
                checkValue = stock2;
            }
            else if (latesPossibleArrival < 4.2)
            {
                if ((stock0 <= 0 || stock1 < 0 || stock2 < 0 || stock0 < t1 || stock1 < t2 || stock2 < t3))
                {
                    orderWithEil = true;
                }
                checkValue = stock2 - t3;
            }
            if (orderWithEil)
            {
                purchase.PurchaseAmount = purchase.DiscountAmount;
                purchase.KindOfDelivery = KindOfDeliveryOptions[1];
            }
            else if (checkValue <= 0)
            {
                purchase.PurchaseAmount = purchase.DiscountAmount;
                purchase.KindOfDelivery = KindOfDeliveryOptions[0];
            }

            return purchase;
        }

        public RelayCommand NextCommand { get; set; }
        public void NextClick()
        {
            AddEverythingToExportModel();
            ServiceLocator.Current.GetInstance<MainViewModel>().export = exportModel;
            CloseAction();
            ShowNextAction();
        }

        private void AddEverythingToExportModel()
        {
            PurchaseModels.ToList().ForEach(item =>
            {
                if (item.PurchaseAmount > 0)
                {
                    if (item.KindOfDelivery.Equals("E"))
                        Purchaseorders.Add(new Order(item.Number, item.PurchaseAmount, 4));
                    else if (item.KindOfDelivery.Equals("N"))
                        Purchaseorders.Add(new Order(item.Number, item.PurchaseAmount, 5));
                }
            });
            exportModel.orderList = Purchaseorders;
        }
    }
}
