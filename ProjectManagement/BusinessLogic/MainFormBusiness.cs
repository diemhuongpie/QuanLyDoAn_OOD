using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BusinessLogic
{
    public class MainFormBusiness
    {
        public MainFormBusiness() { }

        public DirectoryInfo[] GetChildDirectories(string rootPath)
        {
            DirectoryInfo dirs = new DirectoryInfo(rootPath);
            return dirs.GetDirectories();
        }
    }
}
