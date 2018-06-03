using System.Collections.Generic;
using System.Xml.Serialization;

namespace PPS_TOOL_DELUXE.Model.Output
{
        [XmlRoot("input")]
        public class ExportModel
    {
        [XmlElement]
        public QuantityControl quantityControl { get; set; }
        [XmlArray("sellwish")]
        [XmlArrayItem("item")]
        public List<Sellwish> sellwishList { get; set; }
        [XmlArray("selldirect")]
        [XmlArrayItem("item")]
        public List<Selldirect> sellDirectList { get; set; }
        [XmlArray("orderlist")]
        [XmlArrayItem("order")]
        public List<Order> orderList { get; set; }
        [XmlArray("productionlist")]
        [XmlArrayItem("production")]
        public List<Production> productionList { get; set; }
        [XmlArray("workingtimelist")]
        [XmlArrayItem("workingtime")]
        public List<Workingtime> workingtimeList { get; set; }
        //internal
        [XmlIgnore]
        public List<Forecast> forecastList { get; set; }
        [XmlIgnore]
        public List<PlannedSafetystock> plannedSafetystocks { get; set; }

        public ExportModel()
        {
            quantityControl = new QuantityControl("no", 0, 0);
            sellwishList = new List<Sellwish>();
            sellDirectList = new List<Selldirect>();
            orderList = new List<Order>();
            productionList = new List<Production>();
            workingtimeList = new List<Workingtime>();
            forecastList = new List<Forecast>();
            plannedSafetystocks = new List<PlannedSafetystock>();
        }
    }
}
