using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows;

namespace PPS_TOOL_DELUXE
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public CultureInfo CurrentCulture { get; set; }
        public string GetLanguage
        {
            get => CurrentCulture.DisplayName;
        }

        public App()
        {
            CurrentCulture = CultureInfo.CurrentCulture;
            //WriteRessources();
        }

        private void WriteRessources()
        {
            /*var resultsPath = "./ressources/";
            var files = Directory.GetFiles(resultsPath);
            var i = 0;
            files.ToList().ForEach(path =>
            {
                var fileStream = new FileStream(path, FileMode.Open);
                JavaProperties properties = new JavaProperties();
                properties.Load(fileStream);
                ResXResourceWriter writer = new ResXResourceWriter($"c:\\temp\\Resource{i}.resx");
                foreach (var keyValuePair in properties)
                {
                    writer.AddResource(keyValuePair.Key, keyValuePair.Value);
                }
                writer.Generate();
                writer.Close();
                fileStream.Close();
                ++i;
            });*/
        }
    }
}
