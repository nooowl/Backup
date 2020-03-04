using Backup;
using BackupFile.Settings;

namespace BackupFile
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var settings = SettingsLoaderFactory.GetSettingsLoader(args[0]).Load(args[1]);

            var fullPath = DirectoryCreator.CreateWithTimeMark(settings.TargetDirectory);

            Copier.CopyFilesFromAllDirectories(settings.SourceDirectories, fullPath);
        }
    }
}