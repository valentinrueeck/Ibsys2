using System.Xml.Serialization;

namespace PPS_TOOL_DELUXE.Model.Output
{
    public class Selldirect
    {
        [XmlAttribute]
        public int article { get; set; }
        [XmlAttribute]
        public int quantity { get; set; }
        [XmlAttribute]
        public long price { get; set; }
        [XmlAttribute]
        public long penalty { get; set; }

        public Selldirect(int article, int quantity, long price, long penalty)
        {
            this.article = article;
            this.quantity = quantity;
            this.price = price;
            this.penalty = penalty;
        }

        public Selldirect()
        {
            
        }
    }
}
