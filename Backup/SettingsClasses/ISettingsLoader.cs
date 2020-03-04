namespace Backup.SettingsClasses
{
    public interface ISettingsLoader
    {
        Settings Load(string file);
    }
}