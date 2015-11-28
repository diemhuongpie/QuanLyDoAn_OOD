using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public class DTO_Author
    {
        public DTO_Author(
            string id = null,
            string name = null,
            string email = null,
            string phoneNumber = null)
        {
            ID = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string ID;
        public string Name;
        public string Email;
        public string PhoneNumber;
    }
}