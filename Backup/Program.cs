using System;
using Backup.Exceptions;
using Backup.SettingsClasses;

namespace Backup
{
    internal static class Program
    {
        public static void CreateBackup(string[] args)
        {
            if (args == null || args.Length != 2 || args[0] == null || args[1] == null)
            {
                throw new AbortException("Usage: <settings type> <settings file path>");
            }

            Settings settings;
            try
            {
                settings = SettingsLoaderFactory.GetSettingsLoader(args[0]).Load(args[1]);
            }
            catch (Exception e)
            {
                throw new AbortException("Can't load settings", e);
            }

            string fullPath;
            try
            {
                fullPath = DirectoryCreator.CreateWithTimeMark(settings.TargetDirectory);
            }
            catch (Exception e)
            {
                throw new AbortException("Can't create directory", e);
            }

            try
            {
                Copier.CopyFilesFromAllDirectories(settings.SourceDirectories, fullPath);
            }
            catch (Exception e)
            {
                throw new AbortException("Can't copy", e);
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                CreateBackup(args);
            }
            catch (AbortException e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}