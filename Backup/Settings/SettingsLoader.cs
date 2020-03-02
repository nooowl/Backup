using System.IO;
using Newtonsoft.Json;

namespace BackupFile.Settings
{
    public static class SettingsLoader
    {
        /// <summary>
        /// Загружает данные из файла настроек, десериализуя его в экземпляр класса Settings
        /// </summary>
        /// <param name="jsonFile">Имя файла настроек</param>
        /// <returns>Экземпляр класса Settings</returns>
        public static Settings Load(string jsonFile)
        {
            return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(jsonFile));
        }
        
    }
    
    
}