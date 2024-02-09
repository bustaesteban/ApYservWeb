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
    public class clsProfesor
    {
        public Profesore profesor { get; set; }
        private AcademiaSistemasEntities dbProyecto = new AcademiaSistemasEntities();

        public List<Profesore> ListarProfesores()
        {
            return dbProyecto.Profesores
                .OrderBy(p => p.Nombre)
                .ToList();
        }

        public IQueryable ListarProfesoresDetalles()
        {
            return from P in dbProyecto.Set<Profesore>()
                   orderby (P.ProfesorID)
                   select new
                   {
                       ProfesorID = P.ProfesorID,
                       Nombre = P.Nombre,
                       Apellido = P.Apellido,
                       Email = P.Email,
                       Activo = P.Activo
                   };
        }

        public string Insertar()
        {
            dbProyecto.Profesores.Add(profesor);
            dbProyecto.SaveChanges();
            return "Se insertó el profesor: " + profesor.Nombre;
        }

        public string Actualizar()
        {
            dbProyecto.Profesores.AddOrUpdate(profesor);
            dbProyecto.SaveChanges();
            return "Se actualizó el profesor: " + profesor.Nombre;
        }

        public string Eliminar()
        {
            Profesore _profesor = dbProyecto.Profesores.FirstOrDefault(p => p.ProfesorID == profesor.ProfesorID);
            dbProyecto.Profesores.Remove(_profesor);
            dbProyecto.SaveChanges();
            return "Se eliminó el profesor: " + profesor.Nombre;
        }
    }
}
