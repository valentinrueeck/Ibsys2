using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace PPS_TOOL_DELUXE.Model.MasterData.PurchaseItems
{
    public class PurchaseItemsModel
    {
        private static readonly string DEFAULTFILE = "/basedata/purchase-items.xml";
        private static PurchaseItemsModel _instance;
        private purchaseItems _purchaseItems;
        public purchaseItems Purchases
        {
            get => _purchaseItems;
            set => _purchaseItems = value;
        }

        private PurchaseItemsModel() => LoadXmlFile();

        public static PurchaseItemsModel GetInstance()
        {
            return _instance ?? (_instance = new PurchaseItemsModel());
        }

        public List<purchaseItemsItem> GetPurchaseItems() => _purchaseItems.item.ToList();

        private void LoadXmlFile()
        {
            var path = "." + DEFAULTFILE;
            /*if (File.Exists(path))
            {
                var reader = new FileStream(path, FileMode.Open);
            }
            else
            {
                //TODO read from ressources
            }*/

            var settings = new XmlReaderSettings();
            var xmlReader = XmlReader.Create(path, settings);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(purchaseItems));
            _purchaseItems = (purchaseItems)serializer.Deserialize(xmlReader);

            xmlReader.Close();

        }

        public void SaveXmlFile()
        {
            if (!Directory.Exists("./basedata/"))
                Directory.CreateDirectory("./basedata/");

            var path = "." + DEFAULTFILE;
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("\t");
            settings.OmitXmlDeclaration = true;
            var xmlWriter = XmlWriter.Create(path, settings);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(purchaseItems));
            serializer.Serialize(xmlWriter, _purchaseItems);

            xmlWriter.Close();
        }
    }
}
