using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class Config
    {
        // Configure properties
        private string m_storageDir = ROOT_FOLDER_DEFAULT_PATH;
        private string m_storageMode = STORAGE_DIR_MODE_DEFAULT;
        // =========================================

        public const string FILE_SOFTWARE_CONFIG_NAME = "config.pjm";
        public const string FILE_SOFTWARE_CONFIG_HEAD_TAG = "Config";
        public const string FILE_SOFTWARE_CONFIG_XML_NODE_STORAGE_DIR = "StorageDir";
        public const string FILE_SOFTWARE_CONFIG_XML_NODE_STORAGE_DIR_MODE = "StorageDirMode";

        public const string STORAGE_DIR_MODE_DEFAULT = "Default";
        public const string STORAGE_DIR_MODE_CUSTOMIZE = "Customize";
        public const string ROOT_FOLDER_DEFAULT_PATH = "Root";

        public const string FILE_EXTENSION_CHECKLIST = ".req";
        public const string FILE_DIALOG_FILTER_CHECKLIST = "Requirement File|*.req";
        public const string DEFAULT_STRING_NEW_REQUEST = "New Request";

        public const string FILE_NAME_TIME_FORMAT = "hh-mm-ss";
        public const string FILE_NAME_DATE_FORMAT = "dd-mm-yyyy";

        public const string XML_KEY_HEAD_REQUEST = "Request";
        public const string XML_KEY_SUB_REQUEST = "SubRequest";
        public const string XML_KEY_REQUEST_NAME = "RequestName";
        public const string XML_KEY_REQUEST_PRIORITY = "Priority";
        public const string XML_KEY_REQUEST_ISDONE = "Status";

        public const string XML_KEY_COF_HEAD = "Overview";
        public const string XML_KEY_COF_ATTRIBUTE_PROJECT_NAME = "ProjectName";
        public const string XML_KEY_COF_GROUP = "Group";
        public const string XML_KEY_COF_GROUP_ATTRIBUTE_NAME = "GroupName";
        public const string XML_KEY_COF_AUTHOR = "Author";
        public const string XML_KEY_COF_AUTHOR_ATTRIBUTE_NAME = "Name";
        public const string XML_KEY_COF_NOTES = "Notes";
        public const string XML_KEY_COF_NOTE_DETAIL = "Note";

        public const string FILE_NAME_MACRO_INDEX = "$(Index)";
        public const string FILE_NAME_MACRO_TIME = "$(Time)";
        public const string FILE_NAME_MACRO_DATE = "$(Date)";
        public const string FILE_NAME_MACRO_DAY = "$(Day)";
        public const string FILE_NAME_MACRO_MONTH = "$(Month)";
        public const string FILE_NAME_MACRO_YEAR = "$(Year)";
        public const string FILE_NAME_MACRO_DIR = "$(LocDir)";

        public static Dictionary<string, string> m_macroMap = null;

        public const int ERROR_CODE_NONE = 0;
        public const int ERROR_CODE_FILE_NOT_EXISTS = 1;
        public const int ERROR_CODE_FOLDER_NOT_EXITS = 2;
        public const int ERROR_CODE_FOLDER_NOT_EXITS_FORCE_INIT = 3;

        /// <summary>
        /// The method to read the config file of this software, set the default properties.
        /// </summary>
        public void ReadConfiguration()
        {
            var doc = FileBusiness.XmlHandler.readFromFile(FILE_SOFTWARE_CONFIG_NAME, FILE_SOFTWARE_CONFIG_HEAD_TAG);
            var config = doc.Element(XName.Get(FILE_SOFTWARE_CONFIG_HEAD_TAG));
            m_storageMode = config.Element(XName.Get(FILE_SOFTWARE_CONFIG_XML_NODE_STORAGE_DIR_MODE)).Value;
            m_storageDir = config.Element(XName.Get(FILE_SOFTWARE_CONFIG_XML_NODE_STORAGE_DIR)).Value;
        }

        /// <summary>
        /// Set the directory to store the projects source.
        /// </summary>
        /// <param name="newDir">Absolute path to the dir</param>
        /// <param name="isForceInit">Determine if current set call is forced init</param>
        /// <returns>
        ///     + ERROR_COD_NONE: Set successful.
        ///     + ERROR_CODE_FOLDER_NOT_EXITS: Folder not exits, the path not change.
        ///     + ERROR_CODE_FOLDER_NOT_EXITS_FORCE_INIT: Folder not exits, the path changed though.
        /// </returns>
        public int SetConfig(string newDir, string mode, bool isForceInit)
        {
            bool isFolderExits = Directory.Exists(newDir);
            if ( !isFolderExits && !isForceInit )
            {
                return ERROR_CODE_FOLDER_NOT_EXITS;
            }

            m_storageDir = newDir;

            if (!isFolderExits)
            {
                return ERROR_CODE_FOLDER_NOT_EXITS_FORCE_INIT;
            }

            FileBusiness.XmlHandler.writeToFile(FILE_SOFTWARE_CONFIG_NAME, GenerateConfig(), true);

            return ERROR_CODE_NONE;
        }

        /// <summary>
        /// Get the current storage dir.
        /// </summary>
        /// <returns>Absolute path to the dir.</returns>
        public string GetRootDirPath()
        {
            return m_storageDir;
        }

        public string GetStorageDirMode()
        {
            return m_storageMode;
        }

        /// <summary>
        /// Return the last directory from the passed path.
        /// </summary>
        /// <param name="fullPath">The path we get the last dir from.</param>
        /// <returns>The string name of the last directory.</returns>
        public string GetContainerDir (string fullPath)
        {
            fullPath = Path.GetFullPath(fullPath).TrimEnd(Path.DirectorySeparatorChar);
            return fullPath.Split(Path.DirectorySeparatorChar).Last<string>();
        }

        public string MacroProcess(string sourceString, string dir, int indexCounter)
        {
            sourceString = sourceString.Replace(Config.FILE_NAME_MACRO_INDEX, indexCounter.ToString());
            sourceString = sourceString.Replace(Config.FILE_NAME_MACRO_TIME, DateTime.Now.ToString(Config.FILE_NAME_TIME_FORMAT));
            sourceString = sourceString.Replace(Config.FILE_NAME_MACRO_DATE, DateTime.Now.ToString(Config.FILE_NAME_DATE_FORMAT));
            sourceString = sourceString.Replace(Config.FILE_NAME_MACRO_DAY, DateTime.Now.Day.ToString());
            sourceString = sourceString.Replace(Config.FILE_NAME_MACRO_MONTH, DateTime.Now.Month.ToString());
            sourceString = sourceString.Replace(Config.FILE_NAME_MACRO_YEAR, DateTime.Now.Year.ToString());
            sourceString = sourceString.Replace(Config.FILE_NAME_MACRO_DIR, dir);

            return sourceString;
        }

        // =============SINGLETON PATTERN INITIALIZE============
        private static Config m_instance = null;
        private Config() 
        {
            InitializeMacroMap();
        }

        public static Config GetInstance()
        {
            if (m_instance == null)
            {
                m_instance = new Config();
            }

            return m_instance;
        }
        // =====================================================

        /// <summary>
        /// Get a Dictionary<> contain all usable macros.
        /// </summary>
        /// <returns>
        ///     Dictionary<string macro, string explain>
        ///         + macro: the macro key to use in string.
        ///         + explain: it's use when process macro.
        /// </returns>
        public Dictionary<string, string> GetMacroMap ()
        {
            return m_macroMap;
        }

        /// <summary>
        /// Initialize the macro map values for the first use.
        /// </summary>
        private void InitializeMacroMap()
        {
            m_macroMap = new Dictionary<string, string>();

            m_macroMap.Add(FILE_NAME_MACRO_INDEX, "The count number of the generated files.");
            m_macroMap.Add(FILE_NAME_MACRO_TIME, "The file create time.");
            m_macroMap.Add(FILE_NAME_MACRO_DATE, "The short date when the file is created.");
            m_macroMap.Add(FILE_NAME_MACRO_DAY, "The day when create this file.");
            m_macroMap.Add(FILE_NAME_MACRO_MONTH, "The month when create this file.");
            m_macroMap.Add(FILE_NAME_MACRO_YEAR, "The year when create this file.");
            m_macroMap.Add(FILE_NAME_MACRO_DIR, "The directory name store this file.");
        }

        private XDocument GenerateConfig()
        {
            XDocument result = new XDocument(new XElement(FILE_SOFTWARE_CONFIG_HEAD_TAG));
            XElement elementMode = new XElement(FILE_SOFTWARE_CONFIG_XML_NODE_STORAGE_DIR_MODE);
            XElement elementDir = new XElement(FILE_SOFTWARE_CONFIG_XML_NODE_STORAGE_DIR);

            elementMode.Value = m_storageMode;
            elementDir.Value = m_storageDir;
            result.Root.Add(elementMode);
            result.Root.Add(elementDir);
            return result;
        }
    }
}
