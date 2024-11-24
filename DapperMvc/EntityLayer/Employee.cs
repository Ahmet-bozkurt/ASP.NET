using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartDate { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public string email { get; set; }
        public string City { get; set; }

        //isim soyisim birleştirecek
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
