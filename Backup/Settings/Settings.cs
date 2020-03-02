using System.Collections.Generic;

namespace BackupFile.Settings
{
    public class Settings
    {
        public List<string> SourceDirectories { get; set; }
        public string TargetDirectory { get; set; }
    }
}