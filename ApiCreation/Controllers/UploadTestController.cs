using ApiCreation.DataAccessLayer;
using ApiCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiCreation.Controllers
{
    public class UploadTestController : ApiController
    {
        private readonly DAL con = new DAL();

        [System.Web.Http.HttpPost]
        public IHttpActionResult AddTest(TestModel model)
        {
            try
            {
                con.AddTest(model);
                return Ok("");
            }
            catch { }
            return Ok("");
        }
    }
}
