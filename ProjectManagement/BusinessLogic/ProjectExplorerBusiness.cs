using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using DataTransfer;

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
    }
}
