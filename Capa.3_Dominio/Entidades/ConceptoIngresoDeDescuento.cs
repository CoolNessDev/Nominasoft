using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class ConceptoIngresoDeDescuento
    {
        private int id_cid;
        private decimal montoHorasExtras;
        private decimal montoHorasAusente;
        private decimal montoOtrosDescuentos;
        private decimal montoPorAdelanto;
        private decimal montoOtrosIngresos;
        private decimal montoReingreso;
        private Periodo periodo;
        private Contrato contrato;

        public int Id_cid { get => id_cid; set => id_cid = value; }
        public decimal MontoHorasExtras { get => montoHorasExtras; set => montoHorasExtras = value; }
        public decimal MontoHorasAusente { get => montoHorasAusente; set => montoHorasAusente = value; }
        public decimal MontoOtrosDescuentos { get => montoOtrosDescuentos; set => montoOtrosDescuentos = value; }
        public decimal MontoPorAdelanto { get => montoPorAdelanto; set => montoPorAdelanto = value; }
        public decimal MontoOtrosIngresos { get => montoOtrosIngresos; set => montoOtrosIngresos = value; }
        public decimal MontoReingreso { get => montoReingreso; set => montoReingreso = value; }
        public Periodo Periodo { get => periodo; set => periodo = value; }
        public Contrato Contrato { get => contrato; set => contrato = value; }

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
