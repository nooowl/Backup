using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Backup.Settings
{
    [XmlRoot("Settings")]
    public class Settings
    {
        [JsonProperty("SourceDirectories")]
        [XmlArray("SourceDirectories")]
        [XmlArrayItem("SourceDirectory")]
        public string[] SourceDirectories { get; set; }

        [JsonProperty("TargetDirectory")]
        [XmlElement("TargetDirectory")]
        public string TargetDirectory { get; set; }
    }
}