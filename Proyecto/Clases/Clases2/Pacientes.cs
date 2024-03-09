using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases.Clases2
{
    public class MedicStay
    {
        public int ChildBearingAgeWoman { get; set; }
        public DateTime DateOfEntry { get; set; }
        public DateTime DateOfDischarge { get; set; }
        public string MedicalRecord { get; set; }
        public string TypeOfService { get; set; }
        public string Origin { get; set; }
        public string ReasonForDischarge { get; set; }
        public string ConditionsTreated { get; set; }
        public string Comorbidities { get; set; }
        public string ExternalCause { get; set; }
        public string HospitalAcquiredInfection { get; set; }
        public MedicStay() { }
    }
    public class Patient
    {
        public int SocialSecuritynumber { get; set; }
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
    
    public class AssignedMedic
    {
        public int ProfessionalLicense { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AssignedMedic() { }
    }
    
    public class PatientCompanion
    {
        public int Age { get; set; }
        public Boolean Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }

        public PatientCompanion() { }
    }
}



    


