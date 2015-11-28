using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public class DTO_ProjectDetail
    {
        public DTO_ProjectDetail(
            string projectID = null,
            string authorID = null,
            double? score = null,
            string projectName = null,
            DateTime? projectTimeStart = null,
            DateTime? projectTimeEnd = null)
        {
            ProjectID = projectID;
            AuthorID = authorID;
            Score = score;
            ProjectName = projectName;
            ProjectTimeStart = projectTimeStart;
            ProjectTimeEnd = projectTimeEnd;
        }

        public string ProjectID;
        public string AuthorID;
        public double? Score;
        public string ProjectName;
        public DateTime? ProjectTimeStart;
        public DateTime? ProjectTimeEnd;
    }
}
