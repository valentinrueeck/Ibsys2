namespace PPS_TOOL_DELUXE.Model
{
    public class PurchaseItemUsage
    {
        private int purchaseItemNumber;
        private int endProductNumber;
        private int usage;

        public PurchaseItemUsage(int purchaseItemNumber, int endProductNumber, int usage)
        {
            this.purchaseItemNumber = purchaseItemNumber;
            this.endProductNumber = endProductNumber;
            this.usage = usage;
        }
    }
}
