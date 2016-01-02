using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Config
    {
        public const string FILE_EXTENSION_CHECKLIST = ".req";
        public const string FILE_DIALOG_FILTER_CHECKLIST = "Requirement File|*.req";

        public const string FILE_NAME_TIME_FORMAT    = "hh-mm-ss";
        public const string FILE_NAME_DATE_FORMAT    = "dd-mm-yyyy";

        public const string XML_KEY_HEAD_REQUEST     = "Request";
        public const string XML_KEY_SUB_REQUEST      = "SubRequest";
        public const string XML_KEY_REQUEST_NAME     = "RequestName";

        public const string FILE_NAME_MACRO_INDEX    = "$(Index)";
        public const string FILE_NAME_MACRO_TIME     = "$(Time)";
        public const string FILE_NAME_MACRO_DATE     = "$(Date)";
        public const string FILE_NAME_MACRO_DAY      = "$(Day)";
        public const string FILE_NAME_MACRO_MONTH    = "$(Month)";
        public const string FILE_NAME_MACRO_YEAR     = "$(Year)";
        public const string FILE_NAME_MACRO_DIR      = "$(LocDir)";

        public static Dictionary<string, string> m_macroMap = null;

        public const int ERROR_CODE_NONE         = 0;
        public const int ERROR_CODE_FILE_EXISTS  = 1;

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
    }
}
