using System.IO;
using Newtonsoft.Json;

namespace BackupFile.Settings
{
    public class SettingsLoader : ISettingsLoader
    {
        /// <summary>
        /// Загружает данные из файла настроек, десериализуя его в экземпляр класса Settings
        /// </summary>
        /// <param name="file">Имя файла настроек</param>
        /// <returns>Экземпляр класса Settings</returns>
        public Settings Load(string file)
        {
            return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(file));
        }
        
    }

}