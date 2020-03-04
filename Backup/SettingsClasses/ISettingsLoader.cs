namespace Backup.SettingsClasses
{
    public interface ISettingsLoader
    {
        /// <summary>
        /// Загружает данные из файла настроек, десериализуя его в экземпляр класса Settings
        /// </summary>
        /// <param name="file">Имя файла настроек</param>
        /// <returns>Экземпляр класса Settings</returns>
        Settings Load(string file);
    }
}