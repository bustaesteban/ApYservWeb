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
    public class EstudiantesController : ApiController
    {
        // GET api/<controller>
        public Estudiante Get(int EstudianteID)
        {
            ClsEstudiantes estudiantes = new ClsEstudiantes();
            return estudiantes.consultar(EstudianteID);
        }

        
        public string Post([FromBody] Estudiante estudiante)
        {
            ClsEstudiantes estudiantes = new ClsEstudiantes();
            estudiantes.Estudiante = estudiante;
            return estudiantes.insertar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] Estudiante estudiante)
        {
            ClsEstudiantes estudiantes = new ClsEstudiantes();
            estudiantes.Estudiante = estudiante;
            return estudiantes.actualizar();
        }

        // DELETE api/<controller>/5
        public string Delete([FromBody] Estudiante estudiante)
        {
            ClsEstudiantes _estudiantes = new ClsEstudiantes();
            _estudiantes.Estudiante = estudiante;
            return _estudiantes.eliminar();
        }
    }
}