using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using ApiDevMedia.Models;
using System.Web.Http;

namespace ApiDevMedia.Controllers
{
    public class CursosController : ApiController
    {
        private DevMediaContext db = new DevMediaContext();

        public IHttpActionResult PostCurso(Curso curso)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Cursos.Add(curso);
            db.SaveChanges();

            return CreatedAtRoute("DefautApi", new { id = curso.Id }, curso);
        }
    }
}
