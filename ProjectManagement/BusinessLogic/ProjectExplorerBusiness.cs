using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using DataTransfer;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class ProjectExplorerBusiness
    {
        public ProjectExplorerBusiness() { }

        public List<DTO_Project> GetProjectByName(string projectName)
        {
            try
            {
                DataAccess.DataSetTableAdapters.sp_SearchProjectByNameTableAdapter adapter = new DataAccess.DataSetTableAdapters.sp_SearchProjectByNameTableAdapter();
                DataAccess.DataSet.sp_SearchProjectByNameDataTable table = adapter.GetData(projectName);

                List<DTO_Project> result = new List<DTO_Project>();

                foreach (DataAccess.DataSet.sp_SearchProjectByNameRow row in table.Rows)
                {
                    result.Add(new DTO_Project(
                        row.ProjectName, row.GroupName, row.SubjectName, row.Class));
                }

                return result;
            }
            catch (Exception)
            {
                return new List<DTO_Project>();
            }

        }

        public List<DTO_Project> GetProjectByGroup(string groupName)
        {
            try
            {
                DataAccess.DataSetTableAdapters.sp_SearchProjectByGroupTableAdapter adapter = new DataAccess.DataSetTableAdapters.sp_SearchProjectByGroupTableAdapter();
                DataAccess.DataSet.sp_SearchProjectByGroupDataTable table = adapter.GetData(groupName);

                List<DTO_Project> result = new List<DTO_Project>();

                foreach (DataAccess.DataSet.sp_SearchProjectByGroupRow row in table.Rows)
                {
                    result.Add(new DTO_Project(
                        row.ProjectName, row.GroupName, row.SubjectName, row.Class));
                }

                return result;
            }
            catch (Exception)
            {
                return new List<DTO_Project>();
            }

        }

        public List<DTO_Project> GetProjectBySubject(string subjectName)
        {
            try
            {
                DataAccess.DataSetTableAdapters.sp_SearchProjectBySubjectTableAdapter adapter = new DataAccess.DataSetTableAdapters.sp_SearchProjectBySubjectTableAdapter();
                DataAccess.DataSet.sp_SearchProjectBySubjectDataTable table = adapter.GetData(subjectName);

                List<DTO_Project> result = new List<DTO_Project>();

                foreach (DataAccess.DataSet.sp_SearchProjectBySubjectRow row in table.Rows)
                {
                    result.Add(new DTO_Project(
                        row.ProjectName, row.GroupName, row.SubjectName, row.Class));
                }

                return result;
            }
            catch (Exception)
            {
                return new List<DTO_Project>();
            }

        }

        public bool ExportProjectToCofFile(DTO_Project info, string exportDir)
        {
            // OVERVIEW ======================================
            XElement rootElem = new XElement(BusinessLogic.Config.XML_KEY_COF_HEAD, info.Desc);
            rootElem.Add(new XAttribute(BusinessLogic.Config.XML_KEY_COF_ATTRIBUTE_PROJECT_NAME, info.ProjectName));
            XDocument doc = new XDocument(rootElem);

            // AUTHORS =======================================
            XElement authorElem = new XElement(BusinessLogic.Config.XML_KEY_COF_GROUP);
            authorElem.Add(new XAttribute(BusinessLogic.Config.XML_KEY_COF_GROUP_ATTRIBUTE_NAME, info.GroupName));
            foreach (DTO_Author author in info.Authors)
            {
                XElement authorDetail = new XElement(BusinessLogic.Config.XML_KEY_COF_AUTHOR);
                authorDetail.Add(new XAttribute(BusinessLogic.Config.XML_KEY_COF_AUTHOR_ATTRIBUTE_NAME, author.Name));
                authorDetail.Value = author.AdditionalInfo;
                authorElem.Add(authorDetail);
            }

            // NOTES =========================================
            XElement noteElem = new XElement(BusinessLogic.Config.XML_KEY_COF_NOTES);
            foreach (string noteDetail in info.Notes)
            {
                noteElem.Add(new XElement(BusinessLogic.Config.XML_KEY_COF_NOTE_DETAIL, noteDetail));
            }

            // SOURCE EXPORT =================================
            //TODO: copy project source to dir.
            
            // EXPORT COF ====================================
            doc.Add(authorElem);
            doc.Add(noteElem);
            return FileBusiness.XmlHandler.writeToFile(exportDir, doc, true);
        }

        /// <summary>
        /// Read the .cof file to add a new project into database.
        /// The data will be copied to storage directory, returned info is used to add to database.
        /// </summary>
        /// <param name="fullPath">Absolute path to .cof file</param>
        /// <returns>DTO_Project as read data.</returns>
        public DTO_Project  AddProjectByCofFile(string fullPath)
        {
            DTO_Project result = ReadCofFile(fullPath);

            //TODO: copying stuff.

            return result;
        }

        private DTO_Project ReadCofFile(string fullPath)
        {
            try
            {
                DTO_Project result = new DTO_Project();

                XDocument data = FileBusiness.XmlHandler.readFromFile(fullPath, BusinessLogic.Config.XML_KEY_COF_HEAD);

                // OVERVIEW INFO =============================================
                var overview = data.Root.Element(XName.Get(BusinessLogic.Config.XML_KEY_COF_HEAD));
                result.ProjectName = overview.Element(XName.Get(BusinessLogic.Config.XML_KEY_COF_ATTRIBUTE_PROJECT_NAME)).Value;
                result.Desc = overview.Value;

                // GROUP INFO ================================================
                var group = data.Root.Element(XName.Get(BusinessLogic.Config.XML_KEY_COF_GROUP));
                result.GroupName = group.Attribute(XName.Get(BusinessLogic.Config.XML_KEY_COF_GROUP_ATTRIBUTE_NAME)).Value;
                foreach (var author in group.Elements(XName.Get(BusinessLogic.Config.XML_KEY_COF_AUTHOR)))
                {
                    DTO_Author dtoAuthor = new DTO_Author();
                    dtoAuthor.Name = author.Attribute(XName.Get(BusinessLogic.Config.XML_KEY_COF_AUTHOR_ATTRIBUTE_NAME)).Value;
                    dtoAuthor.AdditionalInfo = author.Value;
                    result.Authors.Add(dtoAuthor);
                }

                // NOTES =====================================================
                var notes = data.Root.Element(XName.Get(BusinessLogic.Config.XML_KEY_COF_NOTES));
                foreach (var noteDetail in notes.Elements(XName.Get(BusinessLogic.Config.XML_KEY_COF_NOTE_DETAIL)))
                {
                    result.Notes.Add(noteDetail.Value);
                }

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
