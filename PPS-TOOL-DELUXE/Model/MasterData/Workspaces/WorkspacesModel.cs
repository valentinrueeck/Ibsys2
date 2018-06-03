using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace PPS_TOOL_DELUXE.Model.MasterData.Workspaces
{
    public class WorkspacesModel
    {
        private static readonly string DEFAULTFILE = "/basedata/workspaces.xml";
        private static WorkspacesModel _instance;
        private workspaces _workspaces;
        public workspaces Workspaces
        {
            get => _workspaces;
            set => _workspaces = value;
        }

        private WorkspacesModel() => LoadXmlFile();

        public static WorkspacesModel GetInstance()
        {
            return _instance ?? (_instance = new WorkspacesModel());
        }

        public List<workspacesWorkspace> GetWorkspaces() => _workspaces.workspace.ToList();

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
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(workspaces));
            _workspaces = (workspaces)serializer.Deserialize(xmlReader);

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
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(workspaces));
            serializer.Serialize(xmlWriter, _workspaces);

            xmlWriter.Close();
        }
    }
}
