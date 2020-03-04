using Backup;
using BackupFile.Settings;

namespace BackupFile
{
    internal static class Program
    {
        public const string SettingsFileName = @"D:\ITMO\Разработка ПО\lab1\BackupFile\Backup\Settings.json";
            
        public static void Main()
        {
            var settings = new SettingsLoader().Load(SettingsFileName);

            var fullPath = DirectoryCreator.CreateWithTimeMark(settings.TargetDirectory);

            Copier.CopyFilesFromAllDirectories(settings.SourceDirectories, fullPath);
        }
    }
}