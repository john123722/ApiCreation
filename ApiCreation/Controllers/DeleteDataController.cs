using ApiCreation.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiCreation.Controllers
{
    public class DeleteDataController : ApiController
    {
       private readonly DAL con = new DAL();
        [System.Web.Http.HttpDelete]
        public IHttpActionResult Del(int id)
        {
            con.DeletePatientDetails(id);
            return Ok();
        }
    }
}