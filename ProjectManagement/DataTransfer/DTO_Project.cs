using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public class DTO_Project
    {
        public DTO_Project(
            string projectID = null,
            string groupName = null,
            string subjectName = null,
            string className = null)
        {
            ProjectID = projectID;
            GroupName = groupName;
            SubjectName = subjectName;
            ClassName = className;
        }

        public string ProjectID;
        public string GroupName;
        public string SubjectName;
        public string ClassName;
    }
}
