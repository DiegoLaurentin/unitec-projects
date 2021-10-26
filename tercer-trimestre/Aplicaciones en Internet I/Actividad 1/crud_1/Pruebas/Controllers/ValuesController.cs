using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.PruebasContext db = new Models.PruebasContext())
            {
                var lst = (from d in db.Personas
                           select d).Tolist();

                return Ok(lst);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.personaRequest model)
        {
            using (Models.PruebasContext db = new Models.PruebasContext())
            {
                Models.Persona oPersona = new Models.Persona();
                oPersona.Nombre = model.Nombre;
                oPersona.Edad = model.Edad;
                db.Personas.Add(oPersona);
                db.SaveChanges();
            }

            return Ok();
        }


        [HttpPut]
        public ActionResult Put([FromBody] Models.Request.personaRequest model)
        {
            using (Models.PruebasContext db = new Models.PruebasContext())
            {
                Models.Persona oPersona = db.Personas.Find(model.Id);
                oPersona.Nombre = model.Nombre;
                oPersona.Edad = model.Edad;
                db.Entry(oPersona).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }

            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Models.Request.personaRequest model)
        {
            using (Models.PruebasContext db = new Models.PruebasContext())
            {
                Models.Persona oPersona = db.Personas.Find(model.Id);
                db.Personas.Remove(oPersona);
                db.Savechanges();
            }

            return Ok();
        }
    }
}
