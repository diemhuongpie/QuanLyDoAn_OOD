using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BusinessLogic
{
    public class TreeviewExplorerBusiness
    {
        private const string ROOT_FOLDER_FULL_PATH = "Root";
        public TreeviewExplorerBusiness() { }

        // Get all directly-child directories represented by the path.
        // @param rootPath: the processing absolute-path we gonna get the directories.
        // @return: an array of DirectoryInfo contain information about the directories.
        // IMPORTANT: the method only process on local.
        public DirectoryInfo[] GetChildDirectories(string rootPath)
        {
            DirectoryInfo dirs = new DirectoryInfo(rootPath);
            return dirs.GetDirectories();
        }

        // Get all directly-child files represented by the path.
        // @param rootPath: the absolute-path path we gonna get the files.
        // @return: an array of FileInfo contain information about the files.
        // IMPORTANT: the method only process on local.
        public FileInfo[] GetChildFiles(string rootPath)
        {
            DirectoryInfo dirs = new DirectoryInfo(rootPath);
            return dirs.GetFiles();
        }

        // Delete the folder and any child folder or files represented by the path.
        // @param fullPath: the absolute-path represent to the folder we going to delete.
        public void DeleteFolder(string fullPath)
        {
            if (Directory.Exists(fullPath))
            {
                DirectoryInfo[] childs = GetChildDirectories(fullPath);
                FileInfo[] files = GetChildFiles(fullPath);

                foreach (DirectoryInfo child in childs)
                {
                    DeleteFolder(child.FullName);
                }

                foreach (FileInfo file in files)
                {
                    DeleteFile(file.FullName);
                }

                Directory.Delete(fullPath);
            }
        }

        // Delete the file specified by the path.
        // @param fullPath: the absolute-path reference to the file.
        public void DeleteFile(string fullPath)
        {
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }

        // Return the string contain absolute path to the root folder, contain projects.
        // @return: absolute-path to the Root folder.
        public string GetRootFolderFullPath()
        {
            return ROOT_FOLDER_FULL_PATH;
        }
    }
}
