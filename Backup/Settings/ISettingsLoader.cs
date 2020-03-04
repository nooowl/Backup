namespace Backup.Settings
{
    public interface ISettingsLoader
    {
        Settings Load(string file);
    }
}