using System.IO;
using System.Xml.Serialization;

namespace BackupFile.Settings
{
    public class XmlSettingsLoader : ISettingsLoader
    {
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(Settings));
        
        public Settings Load(string file)
        {
            return (Settings)_serializer.Deserialize(new FileStream(file, FileMode.Open));
        }
    }
}