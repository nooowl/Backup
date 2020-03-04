namespace Backup.Settings
{
    public static class SettingsLoaderFactory
    {
        public static ISettingsLoader GetSettingsLoader(string format)
        {
            switch (format)
            {
                case "json":
                    return new JsonSettingsLoader();
                case "xml":
                    return new XmlSettingsLoader();
                default:
                    return new JsonSettingsLoader();
            }
        }
    }
}