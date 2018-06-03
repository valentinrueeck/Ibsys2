namespace PPS_TOOL_DELUXE.Model
{
    public class PlanningModel
    {
        public int ID { get; set; }
        public int plannedAmount { get; set; }
        public int safetyStock { get; set; }
        public int stockPreviousPeriod { get; set; }
        public int ordersInQueue { get; set; }
        public int ordersInProcess { get; set; }
        public int productionOrder { get; set; }

        public PlanningModel(int id, int plannedAmount, int safetyStock, int stockPreviousPeriod, int ordersInQueue, int ordersInProcess, int productionOrder)
        {
            ID = id;
            this.plannedAmount = plannedAmount;
            this.safetyStock = safetyStock;
            this.stockPreviousPeriod = stockPreviousPeriod;
            this.ordersInQueue = ordersInQueue;
            this.ordersInProcess = ordersInProcess;
            this.productionOrder = productionOrder;
        }
    }
}
