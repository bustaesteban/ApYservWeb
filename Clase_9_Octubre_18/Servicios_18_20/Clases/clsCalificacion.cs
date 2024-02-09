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
    public class clsCalificacion
    {
        public Calificacione calificacion { get; set; }
        private AcademiaSistemasEntities dbProyecto = new AcademiaSistemasEntities();

        public IQueryable ListarCalificacionesConEstudiantesYCurso()
        {
            return from Cal in dbProyecto.Set<Calificacione>()
                   join Est in dbProyecto.Set<Estudiante>()
                   on Cal.EstudianteID equals Est.EstudianteID
                   join Cur in dbProyecto.Set<Curso>()
                   on Cal.CursoID equals Cur.CursoID
                   orderby (Cal.CalificacionID)
                   select new
                   {
                       CodigoEstudiante = Est.EstudianteID,
                       CalificacionID = Cal.CalificacionID,
                       Nota = Cal.Nota,
                       EstudianteNombre = Est.Nombre,
                       CursoID = Cur.CursoID,
                       CursoNombre = Cur.NombreCurso,
                       Activo = Cal.Activo
                   };
        }

        public string Insertar()
        {
            dbProyecto.Calificaciones.Add(calificacion);
            dbProyecto.SaveChanges();
            return "Se insertó la calificación para el estudiante: " + calificacion.EstudianteID;
        }

        public string Actualizar()
        {
            dbProyecto.Calificaciones.AddOrUpdate(calificacion);
            dbProyecto.SaveChanges();
            return "Se actualizó la calificación del estudiante: " + calificacion.EstudianteID;
        }

        public string Eliminar()
        {
            Calificacione _calificacion = dbProyecto.Calificaciones.FirstOrDefault(c => c.CalificacionID == calificacion.CalificacionID);
            dbProyecto.Calificaciones.Remove(_calificacion);
            dbProyecto.SaveChanges();
            return "Se eliminó la calificación: " + calificacion.CalificacionID;
        }
    }
}
