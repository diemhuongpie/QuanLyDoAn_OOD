using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public class DTO_Merged
    {
        public struct Project_Author
        {
            public Project_Author(
                DTO_Project project = null,
                DTO_Author author = null)
            {
                Project = project;
                Author = author;
            }

            public DTO_Project Project;
            public DTO_Author Author;
        }

        public struct Project_ProjectDetail
        {
            public Project_ProjectDetail(
                DTO_Project project = null,
                DTO_ProjectDetail projectDetail = null)
            {
                Project = project;
                ProjectDetail = projectDetail;
            }

            public DTO_Project Project;
            public DTO_ProjectDetail ProjectDetail;
        }

        // More Merged DTO struct here.
    }
}
