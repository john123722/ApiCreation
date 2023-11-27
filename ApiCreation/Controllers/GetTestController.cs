using ApiCreation.DataAccessLayer;
using ApiCreation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiCreation.Controllers
{
    public class GetTestController : ApiController
    {
        private readonly DAL con = new DAL();
        [System.Web.Http.HttpGet]
        public IHttpActionResult Display()
        {
            try
            {
                List<TestModel> data = new List<TestModel>();
                data = con.GetTestDetails();
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