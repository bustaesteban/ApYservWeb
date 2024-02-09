using Servicios_18_20.Clases;
using Servicios_18_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Servicios_18_20.Controllers
{
    [EnableCors(origins: "http://localhost:53462", headers: "*", methods: "*")]
    public class CalificacionController : ApiController
    {
        // GET api/<controller>
        public IQueryable Get()
        {
            clsCalificacion calificacion = new clsCalificacion();
            return calificacion.ListarCalificacionesConEstudiantesYCurso();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public string Post([FromBody] Calificacione _calificacion)
        {
            clsCalificacion calificacion = new clsCalificacion();
            calificacion.calificacion = _calificacion;
            return calificacion.Insertar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] Calificacione _calificacion)
        {
            clsCalificacion calificacion = new clsCalificacion();
            calificacion.calificacion = _calificacion;
            return calificacion.Actualizar();
        }

        // DELETE api/<controller>/5
        public string Delete([FromBody] Calificacione _calificacion)
        {
            clsCalificacion calificacion = new clsCalificacion();
            calificacion.calificacion = _calificacion;
            return calificacion.Eliminar();
        }
    }
}
