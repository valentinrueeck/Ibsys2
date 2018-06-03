namespace PPS_TOOL_DELUXE.Model
{
    public class Forecast
    {
        public int itemNumber { get; set; }
        public int period { get; set; }
        public int amount { get; set; }

        public Forecast(int itemNumber, int period, int amount)
        {
            this.itemNumber = itemNumber;
            this.period = period;
            this.amount = amount;
        }
    }
}
