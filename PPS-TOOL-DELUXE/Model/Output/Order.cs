using System.Xml.Serialization;

namespace PPS_TOOL_DELUXE.Model.Output
{
    public class Order
    {
        [XmlAttribute]
        public int article { get; set; }
        [XmlAttribute]
        public int quantity { get; set; }
        [XmlAttribute]
        public int modus { get; set; }

        public Order(int article, int quantity, int modus)
        {
            this.article = article;
            this.quantity = quantity;
            this.modus = modus;
        }

        public Order()
        {
            
        }
    }
}
