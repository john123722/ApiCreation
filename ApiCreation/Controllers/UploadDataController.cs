using ApiCreation.DataAccessLayer;
using ApiCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace ApiCreation.Controllers
{
    public class UploadDataController : ApiController
    {
        private readonly DAL con = new DAL();
       
        [System.Web.Http.HttpPost]
        public IHttpActionResult Add(PatientModel model)
        {
            try
            {
                int id = con.AddPatient(model);
                return Ok(id);
            }
            catch { }
            return Ok("");
        }

    }
}