using System.Xml.Serialization;

namespace PPS_TOOL_DELUXE.Model.Output
{
    public class Purchaseorder
    {
        [XmlAttribute]
        public int itemNumber { get; set; }
        [XmlAttribute]
        public int orderType { get; set; }
        [XmlAttribute]
        public int amount { get; set; }

        public Purchaseorder(int itemNumber, int orderType, int amount)
        {
            this.itemNumber = itemNumber;
            this.orderType = orderType;
            this.amount = amount;
        }
    }
}
