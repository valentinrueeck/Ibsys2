using System;
using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.Model;
using PPS_TOOL_DELUXE.Model.MasterData.ProduceItems;
using PPS_TOOL_DELUXE.Model.Output;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class Step2ViewModel : ViewModelBase
    {
        public Action CloseAction { get; set; }
        public Action ShowNextAction { get; set; }

        private results rLastPeriod;
        private ExportModel exportModel;
        public List<PlanningModel> AllItemsInTheTable { get; } = new List<PlanningModel>();
        private static produceItems produceItems;
        private List<Item> allParts;
        private List<resultsWarehousestockArticle> allArticle;
        private List<int> allProduceArticle = new List<int>();
        private Dictionary<int, int> allChangesForSecurityStock = new Dictionary<int, int>();

        public Step2ViewModel()
        {
            CancelCommand = new RelayCommand(CancelClick);
            NextCommand = new RelayCommand(NextClick);
        }

        public void Intialize()
        {
            rLastPeriod = ServiceLocator.Current.GetInstance<DashboardViewModel>().LastPeriod;
            exportModel = ServiceLocator.Current.GetInstance<MainViewModel>().export;
            produceItems = ProduceItemsModel.GetInstance().Produces;
            allProduceArticle = produceItems.item.Select(p => p.id).ToList();

            Item one = createOnePartOfListofAllItems(1, 1);
            Item two = createOnePartOfListofAllItems(2, 1);
            Item three = createOnePartOfListofAllItems(3, 1);

            allParts = new List<Item> { one, two, three };

            allArticle = rLastPeriod.warehousestock.article.ToList();

            reCalc(new PlanningModel(1, 0, 100, 0, 0, 0, 0));
        }

        private void reCalc(PlanningModel planningModel)
        {
            AllItemsInTheTable.Clear();
            if (!allChangesForSecurityStock.ContainsKey(planningModel.ID))
                allChangesForSecurityStock.Add(planningModel.ID, planningModel.safetyStock);
            else
            {
                allChangesForSecurityStock.Remove(planningModel.ID);
                allChangesForSecurityStock.Add(planningModel.ID, planningModel.safetyStock);
            }
            AllItemsInTheTable.ForEach(i =>
            {
                if (i.ID == planningModel.ID)
                    i.safetyStock = planningModel.safetyStock;
            });
            if (allParts != null)
                allParts.ForEach(i => reCalculateProduction(i, 100, 0, planningModel));
        }

        private void reCalculateProduction(Item item, int superItemProduction, int superItemProductionInQueue, PlanningModel changeModel)
        {
            var isInList = false;
            var id = item.id;
            int ordersInQueue = getOrdersInQueue(id);
            int ordersInProcess = getOrdersInProcess(id);
            int safetyStock = 100;
            if (allChangesForSecurityStock != null && allChangesForSecurityStock.ContainsKey(id))
            {
                int i;
                if (allChangesForSecurityStock.TryGetValue(id, out i))
                    safetyStock = allChangesForSecurityStock[id];
            }
            int plannedAmount = (superItemProduction * item.need) + superItemProductionInQueue;
            if (id == 1 || id == 2 || id == 3)
            {
                foreach (var i in exportModel.sellwishList)
                {
                    if (id == i.article)
                    {
                        plannedAmount = i.quantity;
                    }
                }
            }
            int amount = getAmount(id);
            PlanningModel addItem = calculateProductionOrder(new PlanningModel(id, plannedAmount, safetyStock, amount, ordersInQueue, ordersInProcess, 0));
            if (allProduceArticle.Contains(id))
            {
                foreach (PlanningModel i in AllItemsInTheTable)
                {
                    if (i.ID == id)
                    {
                        isInList = true;
                        i.plannedAmount = i.plannedAmount + addItem.plannedAmount;
                        i.productionOrder = i.productionOrder + addItem.plannedAmount;
                    }
                }
                if (!isInList)
                {
                    AllItemsInTheTable.Add(addItem);
                }
            }
            item.item.ForEach(i => reCalculateProduction(i, addItem.productionOrder, addItem.ordersInQueue, changeModel));
        }

        private PlanningModel calculateProductionOrder(PlanningModel addItem)
        {
            var tempVal = addItem.plannedAmount + addItem.safetyStock- addItem.stockPreviousPeriod - addItem.ordersInQueue - addItem.ordersInProcess;
            if (addItem.ID == 1 || addItem.ID == 2 || addItem.ID == 3)
            {
                var directSells = exportModel.sellDirectList;
                directSells.ForEach(d =>
                {
                    if (d.article == addItem.ID)
                    {
                        tempVal += d.quantity;
                    }
                });
            }
            if (tempVal < 0)
            {
                tempVal = 0;
            }

            addItem.productionOrder = tempVal;
            return addItem;
        }

        private int getAmount(int id)
        {
            int amount = 0;
            allArticle.ForEach(article =>
            {
                if (article.id == id)
                    amount = article.amount;
            });
            if (id == 16 || id == 17 || id == 26)
            {
                amount = (int)Math.Round((decimal)(amount / 3));
            }
            return amount;
        }

        private int getOrdersInProcess(int id)
        {
            int retVal = 0;
            var allWorkplaces = rLastPeriod.ordersinwork.ToList();
            allWorkplaces.ForEach(workplace =>
            {
                if (workplace.item == id)
                    retVal += workplace.amount;
            });
            if (id == 16 || id == 17 || id == 26)
            {
                retVal = (int)Math.Round((decimal)(retVal / 3));
            }
            return retVal;
        }

        private int getOrdersInQueue(int id)
        {
            int retVal = 0;
            var allWorkplaces = rLastPeriod.waitinglistworkstations.ToList();
            allWorkplaces.ForEach(workplace =>
            {
                workplace.waitinglist?.ToList().ForEach(waitinglist =>
                {
                    if (waitinglist.item == id)
                        retVal += waitinglist.amount;
                });
            });
            if (id == 16 || id == 17 || id == 26)
            {
                retVal = (int) Math.Round((decimal) (retVal / 3));
            }
            return retVal;
        }

        private Item createOnePartOfListofAllItems(int id, int need)
        {
            var subItems = new List<Item>();
            var item = produceItems.item.FirstOrDefault(i => i.id == id);
            item?.subComponentList.ToList().ForEach(subItem =>
            {
                subItems.Add(createOnePartOfListofAllItems(subItem.id, subItem.need));
            });
            return new Item(id, need, subItems);
        }

        public RelayCommand CancelCommand { get; set; }
        public void CancelClick()
        {
            allChangesForSecurityStock.Clear();
        }

        public RelayCommand NextCommand { get; set; }
        public void NextClick()
        {
            allChangesForSecurityStock.Clear();
            AddEverythingToExportModel();
            ServiceLocator.Current.GetInstance<MainViewModel>().export = exportModel;
            CloseAction();
            ShowNextAction();
        }

        private void AddEverythingToExportModel()
        {
            List<Production> productionList = new List<Production>();
            List<PlannedSafetystock> plannedSafetystocks = new List<PlannedSafetystock>();
            AllItemsInTheTable.ForEach(i =>
            {
                Production p = new Production(i.ID, i.productionOrder);
                productionList.Add(p);
                PlannedSafetystock pss = new PlannedSafetystock(i.ID, i.safetyStock);
                plannedSafetystocks.Add(pss);
            });
            exportModel.productionList = productionList;
            exportModel.plannedSafetystocks = plannedSafetystocks;
        }
    }
}
