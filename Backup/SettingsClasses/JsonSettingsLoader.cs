using System.IO;
using Newtonsoft.Json;

namespace Backup.SettingsClasses
{
    public class JsonSettingsLoader : ISettingsLoader
    {
        /// <summary>
        /// Загружает данные из файла настроек формата json, десериализуя его в экземпляр класса Settings
        /// </summary>
        /// <param name="file">Имя файла настроек</param>
        /// <returns>Экземпляр класса Settings</returns>
        public Settings Load(string file)
        {
            return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(file));
        }
        
    }

}