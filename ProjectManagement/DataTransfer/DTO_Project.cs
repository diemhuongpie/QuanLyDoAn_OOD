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
            string className = null,
            string desc = null)
        {
            ProjectName = projectID;
            GroupName = groupName;
            SubjectName = subjectName;
            ClassName = className;
            Desc = desc;
            Notes = new List<string>();
            Authors = new List<DTO_Author>();
        }

        public string ProjectName;
        public string GroupName;
        public string SubjectName;
        public string ClassName;
        public string Desc;
        public List<string> Notes;
        public List<DTO_Author> Authors;
    }
}
