using System.Collections.Generic;

namespace Backup.Settings
{
    public class Settings
    {
        public List<string> SourceDirectories { get; set; }
        public string TargetDirectory { get; set; }
    }
}