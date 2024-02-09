using Servicios_18_20.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Servicios_18_20.Clases
{
    public class clsCurso
    {
        public Curso curso { get; set; }
        private AcademiaSistemasEntities dbProyecto = new AcademiaSistemasEntities();

        public IQueryable ListarCursosConProfesores()
        {
            return from C in dbProyecto.Set<Curso>()
                   join P in dbProyecto.Set<Profesore>()
                   on C.ProfesorID equals P.ProfesorID
                   orderby (C.CursoID)
                   select new
                   {
                       CodigoProfesor = P.ProfesorID,
                       CursoID = C.CursoID,
                       NombreCurso = C.NombreCurso,
                       Descripcion = C.Descripcion,
                       ProfesorNombre = P.Nombre,
                       Activo = C.Activo
                   };
        }

        public string Insertar()
        {
            dbProyecto.Cursos.Add(curso);
            dbProyecto.SaveChanges();
            return "Se insertó el curso: " + curso.NombreCurso;
        }

        public string Actualizar()
        {
            dbProyecto.Cursos.AddOrUpdate(curso);
            dbProyecto.SaveChanges();
            return "Se actualizó el curso: " + curso.NombreCurso;
        }

        public string Eliminar()
        {
            Curso _curso = dbProyecto.Cursos.FirstOrDefault(c => c.CursoID == curso.CursoID);
            dbProyecto.Cursos.Remove(_curso);
            dbProyecto.SaveChanges();
            return "Se eliminó el curso: " + curso.CursoID;
        }
    }
}
