using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;

namespace BusinessLogic
{
    public class ProjectExplorerBusiness
    {
        private DataSet m_dataAccessObject = new DataSet();

        public ProjectExplorerBusiness() { }

        public DataSet.sp_SearchProjectByNameDataTable GetProjectByName(string projectName)
        {
            DataAccess.DataSetTableAdapters.sp_SearchProjectByNameTableAdapter adapter = new DataAccess.DataSetTableAdapters.sp_SearchProjectByNameTableAdapter();

            return adapter.GetData(projectName);
        }
    }
}
