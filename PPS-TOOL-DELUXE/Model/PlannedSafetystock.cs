namespace PPS_TOOL_DELUXE.Model
{
    public class PlannedSafetystock
    {
        public int itemNumber { get; set; }
        public int amount { get; set; }

        public PlannedSafetystock(int itemNumber, int amount)
        {
            this.itemNumber = itemNumber;
            this.amount = amount;
        }
    }
}
