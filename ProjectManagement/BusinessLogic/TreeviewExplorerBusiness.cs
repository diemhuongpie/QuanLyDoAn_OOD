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

        public DirectoryInfo[] GetChildDirectories(string rootPath)
        {
            DirectoryInfo dirs = new DirectoryInfo(rootPath);
            return dirs.GetDirectories();
        }

        public FileInfo[] GetChildFiles(string rootPath)
        {
            DirectoryInfo dirs = new DirectoryInfo(rootPath);
            return dirs.GetFiles();
        }

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

        public void DeleteFile(string fullPath)
        {
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }

        public string GetRootFolderFullPath()
        {
            return ROOT_FOLDER_FULL_PATH;
        }
    }
}
