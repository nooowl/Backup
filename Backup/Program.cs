using BackupFile.Settings;

namespace BackupFile
{
    
    internal static class Program
    {
        public static void Main()
        {
            var settings = SettingsLoader.Load(@"D:\ITMO\Разработка ПО\lab1\BackupFile\Backup\Settings.json");

            var fullPath = DirectoryCreator.CreateWithTimeMark(settings.TargetDirectory);

            Copier.CopyFilesFromAllDirectories(settings.SourceDirectories, fullPath);
        }
    }
}