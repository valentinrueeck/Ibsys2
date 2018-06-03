using System.Xml.Serialization;

namespace PPS_TOOL_DELUXE.Model.Output
{
    public class Workingtime
    {
        [XmlAttribute]
        public int station { get; set; }
        [XmlAttribute]
        public int shift { get; set; }
        [XmlAttribute]
        public int overtime { get; set; }

        public Workingtime(int station, int shift, int overtime)
        {
            this.station = station;
            this.shift = shift;
            this.overtime = overtime;
        }

        public Workingtime()
        {
            
        }
    }
}
