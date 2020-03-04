namespace BackupFile.Settings
{
    public interface ISettingsLoader
    {
        Settings Load(string file);
    }
}