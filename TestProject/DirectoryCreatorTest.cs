using System.IO;
using Backup;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class DirectoryCreatorTest
    {
        private string _directory;

        [Test]
        [TestCase("abc")]
        [TestCase("12345")]
        [TestCase("abcd  123")]
        [TestCase("абвгде")]
        public void CreatePositive(string targetDirectory)
        {
            var created = DirectoryCreator.CreateWithTimeMark(targetDirectory);
            _directory = targetDirectory;
            Assert.IsTrue(Directory.Exists(created), "Directory doesn't exist");
        }

        [Test]
        [TestCase("P:\\123")]
        [TestCase("12:345")]
        [TestCase(null)]
        public void CreateNegative(string targetDirectory)
        {
            Assert.That(() => { DirectoryCreator.CreateWithTimeMark(targetDirectory); },
                Throws.Exception);
        }

        [TearDown]
        public void Clear()
        {
            if (_directory != null)
                Directory.Delete(_directory, true);
            _directory = null;
        }
    }
}