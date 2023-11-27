using ApiCreation.DataAccessLayer;
using ApiCreation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiCreation.Controllers
{
    public class GetPatientAndTestController : ApiController
    {
        private readonly DAL con = new DAL();
        [System.Web.Http.HttpGet]
        public IHttpActionResult DisplayDetails()
        {
            try
            {
                List<PatientReportModel> data = new List<PatientReportModel>();
                data = con.GetPatientAndTestDetails();
                if (data.Count==0)
                {
                    Debug.WriteLine("No Data");
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }
    }
}
