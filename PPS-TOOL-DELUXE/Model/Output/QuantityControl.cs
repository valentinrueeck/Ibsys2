using System.Xml.Serialization;

namespace PPS_TOOL_DELUXE.Model.Output
{
    public class QuantityControl
    {
        [XmlAttribute]
        public string type { get; set; }
        [XmlAttribute]
        public int losequantity { get; set; }
        [XmlAttribute]
        public int delay { get; set; }

        public QuantityControl(string type, int losequantity, int delay)
        {
            this.type = type;
            this.losequantity = losequantity;
            this.delay = delay;
        }

        public QuantityControl()
        {
            
        }
    }
}
