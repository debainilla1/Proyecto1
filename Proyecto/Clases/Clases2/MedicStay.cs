﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Classes
{
    public class MedicStay
    {

        public int ChildBearingAgeWoman { get; set; }
        public int ID { get; set; }
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
}