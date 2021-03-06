﻿using System;
using System.IO;

namespace Backup
{
    public static class DirectoryCreator
    {
        private const string DateFormat = "dd.MM.yyyy HH-mm";
        private static string FolderName =>
            DateTime.Now.ToString(DateFormat);

        private static string GetFullPath(string targetDirectory) =>
            Path.Combine(targetDirectory, FolderName);

        /// <summary>
        /// В указанной директории создает новую директорию,
        /// именем которой являестя текущее время в формате 'дд.мм.гг чч-мм'.
        /// Если {targetDirectory} не существовало, то она создается 
        /// </summary>
        /// <param name="targetDirectory">
        /// Директория, в которой требуется создать директорию с временной меткой</param>
        /// <returns>
        /// Имя созданной директории
        /// </returns>
        public static string CreateWithTimeMark(string targetDirectory) =>
            Directory.CreateDirectory(GetFullPath(targetDirectory)).FullName; 
        
    }
}