using System.Collections.Generic;
using System.IO;
using System.Linq;
using Backup;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class CopierTests
    {
        private const string SourceFile = @"TestResources\TestDirectory1\Devil.png";
        private const string TempDirectory = @"TestResources\Temp";
        private const string SourceDirectory = @"TestResources\TestDirectory1";
        private static readonly List<string> Directories = new List<string>
        {
            @"TestResources\TestDirectory1", 
            @"TestResources\TestDirectory2"
        };


        private static bool CheckExists(string directoryFullPath, string file)
        {
            return System.IO.File.Exists(Path.Combine(directoryFullPath,
                file.Split('\\').Last()));
        }
        
        [Test]
        public void CopyOneFile()
        {
            Copier.CopyOneFile(SourceFile, TempDirectory);
            Assert.IsTrue(CheckExists(TempDirectory, SourceFile));
        }

        [Test]
        public void CopyFilesFromDirectory()
        {
            Copier.CopyFilesFromDirectory(SourceDirectory, TempDirectory);
            foreach (var file in Directory.EnumerateFiles(SourceDirectory))
            {
                Assert.IsTrue(CheckExists(TempDirectory, file));
            }
        }

        [Test]
        public void CopyFilesFromAllDirectories()
        {
            Copier.CopyFilesFromAllDirectories(Directories, TempDirectory);
            foreach (var directory in Directories)
            {
                foreach (var file in Directory.EnumerateFiles(directory))
                {
                    Assert.IsTrue(CheckExists(TempDirectory, file));
                }
            }
        }

        [TearDown]
        public void Clear()
        {
            foreach (var file in Directory.EnumerateFiles(TempDirectory))
            {
                File.Delete(file);
            }
        }
    }
}