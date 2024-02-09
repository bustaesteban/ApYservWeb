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
    public class CursoController : ApiController
    {
        // GET api/<controller>
        public IQueryable Get()
        {
            clsCurso curso = new clsCurso();
            return curso.ListarCursosConProfesores();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public string Post([FromBody] Curso _curso)
        {
            clsCurso curso = new clsCurso();
            curso.curso = _curso;
            return curso.Insertar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] Curso _curso)
        {
            clsCurso curso = new clsCurso();
            curso.curso = _curso;
            return curso.Actualizar();
        }

        // DELETE api/<controller>/5
        public string Delete([FromBody] Curso _curso)
        {
            clsCurso curso = new clsCurso();
            curso.curso = _curso;
            return curso.Eliminar();
        }
    }
}
