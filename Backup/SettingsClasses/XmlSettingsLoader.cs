using System.IO;
using System.Xml.Serialization;

namespace Backup.SettingsClasses
{
    public class XmlSettingsLoader : ISettingsLoader
    {
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(Settings));
        
        /// <summary>
        /// Загружает данные из файла настроек формата xml, десериализуя его в экземпляр класса Settings
        /// </summary>
        /// <param name="file">Имя файла настроек</param>
        /// <returns>Экземпляр класса Settings</returns>
        public Settings Load(string file)
        {
            return (Settings)_serializer.Deserialize(new FileStream(file, FileMode.Open));
        }
    }
}