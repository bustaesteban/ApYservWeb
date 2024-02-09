using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_18_20.Models
{
    public class NotasSuficiencia
    {

        public NotasSuficiencia()
        {
            PorcentajeNotaPractica = 0.50;
            PorcentajeNotaTeorica = 0.25;
            PorcentajeNotaTrabajo = 0.25;
        }

        public double NotaPractica { get; set; }
        public double NotaTeorica { get; set; }
        public double NotaTrabajo { get; set; }
        public double NotaOficial { get; set; }
        public double NotaSuficiencia { get; set; }
        public double PorcentajeNotaPractica { get; set; }
        public double PorcentajeNotaTeorica { get; set; }   //Se dejan publicas porque los metodos iran en otra clase
        public double PorcentajeNotaTrabajo { get; set; }
        public string Error { get; set; }
    }
}