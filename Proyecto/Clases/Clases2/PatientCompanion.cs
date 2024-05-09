using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Classes
{
    public class PatientCompanion
    {
        public int Age { get; set; }
        public int ID { get; set; }
        public Boolean Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }

        public PatientCompanion() { }
    }
}