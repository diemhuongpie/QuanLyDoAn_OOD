using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public class DTO_TagDetail
    {
        public DTO_TagDetail(
            string projectID = null,
            string tagName = null)
        {
            ProjectID = projectID;
            TagName = tagName;
        }

        public string ProjectID;
        public string TagName;
    }
}
