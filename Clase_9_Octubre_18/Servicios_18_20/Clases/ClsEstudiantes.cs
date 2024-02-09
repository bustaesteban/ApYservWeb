using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases
{
    public class ClsEstudiantes
    {
       public Estudiante Estudiante { get; set; }
       private AcademiaSistemasEntities dbProyecto = new AcademiaSistemasEntities();

      
      public Estudiante consultar (int EstudianteID) 
        {
            return dbProyecto.Estudiantes.FirstOrDefault(e => e.EstudianteID == EstudianteID);

        }

      
        public string insertar() 
        {
            try
            {
                dbProyecto.Estudiantes.Add(Estudiante);
                dbProyecto.SaveChanges();
                return "El estudiante: " + Estudiante.Nombre + "ha sido registrado";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

    

        public string actualizar()
        {
            try
            {
                Estudiante _estudiante = consultar(Estudiante.EstudianteID);
                if(_estudiante == null) 
                {
                    return "No se ha encontrado el estudiante";
                }

                _estudiante.Nombre = Estudiante.Nombre;
                _estudiante.Apellido = Estudiante.Apellido;
                _estudiante.FechaNacimiento = Estudiante.FechaNacimiento;
                _estudiante.Email = Estudiante.Email;
                dbProyecto.SaveChanges();
                return "Se ha actualizado los datos del estudiante " + Estudiante.Nombre + "exitosamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            
        }

        public string eliminar() 
        {

            try
            {
                Estudiante estudiante = consultar(Estudiante.EstudianteID);
                if (estudiante == null)
                {
                    return "No se ha encontrado el estudiante";
                }

                dbProyecto.Estudiantes.Remove(estudiante);
                dbProyecto.SaveChanges();
                return "Se han eliminado los datos del estudiante " + Estudiante.Nombre + "exitosamente";


            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}