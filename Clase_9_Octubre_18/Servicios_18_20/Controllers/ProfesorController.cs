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
    public class ProfesorController : ApiController
    {
        // GET api/Profesor
        public List<Profesore> Get()
        {
            clsProfesor profesor = new clsProfesor();
            return profesor.ListarProfesores();
        }

        // GET api/Profesor/Detalles
        [Route("api/Profesor/Detalles")]
        public IQueryable ListarProfesoresDetalles()
        {
            clsProfesor profesor = new clsProfesor();
            return profesor.ListarProfesoresDetalles();
        }

        // POST api/Profesor
        public string Post([FromBody] Profesore _profesor)
        {
            clsProfesor profesor = new clsProfesor();
            profesor.profesor = _profesor;
            return profesor.Insertar();
        }

        // PUT api/Profesor
        public string Put([FromBody] Profesore _profesor)
        {
            clsProfesor profesor = new clsProfesor();
            profesor.profesor = _profesor;
            return profesor.Actualizar();
        }

        // DELETE api/Profesor
        public string Delete([FromBody] Profesore _profesor)
        {
            clsProfesor profesor = new clsProfesor();
            profesor.profesor = _profesor;
            return profesor.Eliminar();
        }
    }
}

