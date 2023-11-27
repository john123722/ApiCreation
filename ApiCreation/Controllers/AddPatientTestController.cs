using ApiCreation.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiCreation.Models;

namespace ApiCreation.Controllers
{
    public class AddPatientTestController : ApiController
    {
        private readonly DAL con = new DAL();
        [System.Web.Http.HttpPost]
        public IHttpActionResult AddReport(CombinedViewModel model)
        {
            con.SavePatientTest(model.SelectedPatientId, model.Ints);
            return Ok();
        }
    }
}
