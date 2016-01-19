using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Xml.Linq;

namespace BusinessLogic
{
    public enum SaveType
    {
        TRY = 0,
        OVERRIDE
    };

    public class NewChecklistBusiness
    {
        private static int m_indexCounter = 0;
        private ChecklistViewBusiness m_checklistViewBusiness = new ChecklistViewBusiness();

        /// <summary>
        /// Generate a string that specify the save file from the imported information.
        /// The file saved with the extension as ".req".
        /// IMPORTANT: the file name will be processed by the macros if possible.
        /// </summary>
        /// <param name="dirPath">Absolute path to the directory where save the file</param>
        /// <param name="fileName">File name without extension</param>
        /// <returns>Absolute path to the file with extension</returns>
        public string SaveLinkProcess(string dirPath, string fileName)
        {
            if (!dirPath.EndsWith("\\", StringComparison.OrdinalIgnoreCase))
            {
                dirPath += "\\";
            }

            string fullFilePath = dirPath +
                Config.GetInstance().MacroProcess(fileName, Config.GetInstance().GetContainerDir(dirPath), m_indexCounter) +
                Config.FILE_EXTENSION_CHECKLIST;

            return fullFilePath;
        }

        /// <summary>
        /// Display a messagebox to warning the imported error.
        /// </summary>
        /// <param name="errorCode">One of the error code in BusinessLogic.Config</param>
        /// <param name="extraInfomation">A string displayed after main warning on messagebox</param>
        /// <returns>
        ///     true: If user do a selection to ignore this warning and continue.
        ///     false: otherwise.
        /// </returns>
        public bool WarningErrorIfContinue(int errorCode, string extraInfomation)
        {
            switch (errorCode)
            {
                case Config.ERROR_CODE_FILE_EXISTS:
                    DialogResult result = MessageBox.Show("This file already exits.\nDo you want to override it?\n\n" + extraInfomation, "Cannot save.", MessageBoxButtons.OKCancel);
                    return result == DialogResult.OK;

                case Config.ERROR_CODE_NONE:
                    return false;

                default:
                    break;
            }

            return false;
        }
    }
}
