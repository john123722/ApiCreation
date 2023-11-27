using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiCreation.Models
{
    public class PatientReportModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
        public string Contact { get; set; }

        public string TestName { get; set; }
        public string Price { get; set; }
    }
}