using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Backup
{
    public static class Copier
    {
        /// <summary>
        /// Копирует указанный файл в указанную директорию
        /// </summary>
        /// <param name="file">Копируемый файл</param>
        /// <param name="directoryFullPath">Директория, в которую происходит копирование</param>
        public static void CopyOneFile(string file, string directoryFullPath)
        {
            File.Copy(file,
                Path.Combine(directoryFullPath,
                    file.Split('\\').Last()));
        }

        /// <summary>
        /// Копирует указанные файлы в директорию
        /// </summary>
        /// <param name="files">Копируемые файлы</param>
        /// <param name="directoryFullPath">Директория, в которую происходит копирование</param>
        public static void CopyAllFiles(IEnumerable<string> files, string directoryFullPath)
        {
            foreach (var file in files)
            {
                CopyOneFile(file, directoryFullPath);
            }
        }
        
        /// <summary>
        /// Копирует одну указанную директорию в другую
        /// </summary>
        /// <param name="directory">Директория, из которой копируют</param>
        /// <param name="directoryFullPath">Директория, в которую происходит копирование</param>
        public static void CopyFilesFromDirectory(string directory, string directoryFullPath)
        {
            CopyAllFiles(Directory.EnumerateFiles(directory), directoryFullPath);
        }

        /// <summary>
        /// Копирует указанные директории из списка в другую дирекорию
        /// </summary>
        /// <param name="directories">Список копируемых директорий</param>
        /// <param name="directoryFullPath">Директория, в которую происходит копирование</param>
        public static void CopyFilesFromAllDirectories(IList<string> directories, string directoryFullPath)
        {
            foreach (var directory in directories)
            {
                CopyFilesFromDirectory(directory, directoryFullPath);
            }
        }
    }
}