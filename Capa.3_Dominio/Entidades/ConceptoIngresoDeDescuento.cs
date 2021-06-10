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
        private float montoHorasExtras;
        private float montoHorasAusente;
        private float montoOtrosDescuentos;
        private float montoPorAdelanto;
        private float montoOtrosIngresos;
        private float montoReingreso;
        private Periodo periodo;

        public int Id_cid { get => id_cid; set => id_cid = value; }
        public float MontoHorasExtras { get => montoHorasExtras; set => montoHorasExtras = value; }
        public float MontoHorasAusente { get => montoHorasAusente; set => montoHorasAusente = value; }
        public float MontoOtrosDescuentos { get => montoOtrosDescuentos; set => montoOtrosDescuentos = value; }
        public float MontoPorAdelanto { get => montoPorAdelanto; set => montoPorAdelanto = value; }
        public float MontoOtrosIngresos { get => montoOtrosIngresos; set => montoOtrosIngresos = value; }
        public float MontoReingreso { get => montoReingreso; set => montoReingreso = value; }
        public Periodo Periodo { get => periodo; set => periodo = value; }

        public double CalcularTotalConceptoDescuento()
        {
            return MontoHorasAusente + MontoPorAdelanto + MontoOtrosDescuentos;
        }

        public double CalcularTotalConceptoIngreso()
        {
            return MontoHorasExtras + MontoReingreso + MontoOtrosIngresos;
        }
    }
}
