using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PPS_TOOL_DELUXE.Annotations;

namespace PPS_TOOL_DELUXE.Model
{
    public class PurchaseModel : INotifyPropertyChanged
    {
        private string _kindOfDelivery;
        public int Number { get; }
        public double StockValue { get; }
        public TimeModel Timemodel { get; }
        public string OpenOrders { get; }
        public double NormalDeliveryDate { get; }
        public double LatestDeliveryDate { get; }
        public double HurryUpDeliveryDate { get; }
        public int DiscountAmount { get; }
        public int PurchaseAmount { get; set; }

        public string KindOfDelivery
        {
            get => _kindOfDelivery;
            set { _kindOfDelivery = value; OnPropertyChanged(); }
        }

        public PurchaseModel(int number, double stockValue, TimeModel timeModel, string openOrders, double normalDeliveryDate, double latestDeliveryDate, double hurryUpDeliveryDate, int discountAmount, int purchaseAmount, string kindOfDelivery)
        {
            this.Number = number;
            this.StockValue = stockValue;
            this.Timemodel = timeModel;
            this.OpenOrders = openOrders;
            this.NormalDeliveryDate = normalDeliveryDate;
            this.LatestDeliveryDate = latestDeliveryDate;
            this.HurryUpDeliveryDate = hurryUpDeliveryDate;
            this.DiscountAmount = discountAmount;
            this.PurchaseAmount = purchaseAmount;
            this.KindOfDelivery = kindOfDelivery;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool Equals(PurchaseModel other)
        {
            return string.Equals(_kindOfDelivery, other._kindOfDelivery) && Number == other.Number && StockValue.Equals(other.StockValue) && Equals(Timemodel, other.Timemodel) && string.Equals(OpenOrders, other.OpenOrders) && NormalDeliveryDate.Equals(other.NormalDeliveryDate) && LatestDeliveryDate.Equals(other.LatestDeliveryDate) && HurryUpDeliveryDate.Equals(other.HurryUpDeliveryDate) && DiscountAmount == other.DiscountAmount && PurchaseAmount == other.PurchaseAmount;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PurchaseModel) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_kindOfDelivery != null ? _kindOfDelivery.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Number;
                hashCode = (hashCode * 397) ^ StockValue.GetHashCode();
                hashCode = (hashCode * 397) ^ (Timemodel != null ? Timemodel.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (OpenOrders != null ? OpenOrders.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ NormalDeliveryDate.GetHashCode();
                hashCode = (hashCode * 397) ^ LatestDeliveryDate.GetHashCode();
                hashCode = (hashCode * 397) ^ HurryUpDeliveryDate.GetHashCode();
                hashCode = (hashCode * 397) ^ DiscountAmount;
                hashCode = (hashCode * 397) ^ PurchaseAmount;
                return hashCode;
            }
        }
    }
}
