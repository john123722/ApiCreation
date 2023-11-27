using ApiCreation.DataAccessLayer;
using ApiCreation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace ApiCreation.Controllers
{
    public class GetDataController : ApiController
    {
        private readonly DAL con = new DAL();
        [System.Web.Http.HttpGet]
        public IHttpActionResult Display()
        {
            try
            {
                List <PatientModel> data = new List <PatientModel> ();
                data = con.GetPatientDetails();
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

        [System.Web.Http.HttpGet]
        public IHttpActionResult Display(int id)
        {
            try
            {
                var result = con.GetDetails(id);
                if (result == null)
                {
                    Debug.WriteLine("Sorry! No data available");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }
    }
}
