using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Classes
{
    public class Patient
    {
        public int SocialSecuritynumber { get; set; }
        public int ID { get; set; }
        public int MaritalStatus { get; set; }
        public int Weight { get; set; }
        public int ZipCode { get; set; }
        public int PhoneNumber { get; set; }
        public Boolean Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Curp { get; set; }
        public string BirthPlace { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Municipality { get; set; }
        public Patient() { }
    }
}

