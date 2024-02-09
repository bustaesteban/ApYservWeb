using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_18_20.Models
{
    public class LiquidacionMatricula
    {
        public LiquidacionMatricula()
        {
            ValorCredito = 70000;
            NroCreditosXAsignaturaBasica = 2;
            NroCreditosXAsignaturaComplementaria = 1;
            NroCreditosXAsignaturaEspecializada = 3;
            PorcentajeIVA = 0.19;
            MinimoCreditos = 6;
            MaximoCreditos = 15;
        }
        public int AsignaturasBasicas { get; set; }
        public int AsignaturasComplementarias { get; set; }
        public int AsignaturasEspecializadas { get; set; }
        public int TotalCreditos { get; set; }
        public int ValorCredito { get; set; }
        public int ValorAntesIVA { get; set; }
        public int ValorIVA { get; set; }
        public int ValorPagar { get; set; }
        public int NroCreditosXAsignaturaBasica { get; set; }
        public int NroCreditosXAsignaturaComplementaria { get; set; }
        public int NroCreditosXAsignaturaEspecializada { get; set; }
        public int MinimoCreditos { get; set; }
        public int MaximoCreditos { get; set; }
        public double PorcentajeIVA { get; set; }
        public string Error { get; set; }
    }
}