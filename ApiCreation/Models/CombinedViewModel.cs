using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ApiCreation.Models
{
    public class CombinedViewModel
    {
        public List<PatientModel> PatientList { get; set; }
        public List<TestModel> TestList { get; set; }
        public int SelectedPatientId { get; set; }
        public int[] Ints { get; set; }
    }
}