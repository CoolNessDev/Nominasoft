using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class ConceptoIngresoDeDescuento
    {
        public int Id_cid { get; set; }
        public decimal MontoHorasExtras { get; set; }
        public decimal MontoHorasAusente { get; set; }
        public decimal MontoOtrosDescuentos { get; set; }
        public decimal MontoPorAdelanto { get; set; }
        public decimal MontoOtrosIngresos { get; set; }
        public decimal MontoReingreso { get; set; }
        public Periodo Periodo { get; set; }
        public Contrato Contrato { get; set; }

        public decimal CalcularTotalConceptoDescuento()
        {
            return MontoHorasAusente + MontoPorAdelanto + MontoOtrosDescuentos;
        }

        public decimal CalcularTotalConceptoIngreso()
        {
            return MontoHorasExtras + MontoReingreso + MontoOtrosIngresos;
        }
    }
}
