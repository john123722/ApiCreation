using ApiCreation.DataAccessLayer;
using ApiCreation.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiCreation.Controllers
{
    public class EditDataController : ApiController
    {
        private readonly DAL con = new DAL();
        [System.Web.Http.HttpPost]
        public IHttpActionResult Edit(PatientModel model)
        {
            if (ModelState.IsValid)
            {
                con.EditPatientDetails(model, model.Id);
                ModelState.Clear();
            }

            return Ok("");
        }
    }
}