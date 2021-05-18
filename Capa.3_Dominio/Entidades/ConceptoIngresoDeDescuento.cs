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
        private float montoHorasAuxente;
        private float montoOtrosDescuento;
        private float montoPorAdelanto;
        private float montoPorOtrosDescuentos;
        private float montoReingreso;

        private Contrato contrato;
        private Periodo periodo;

        public int Id_cid { get => id_cid; set => id_cid = value; }
        public float MontoHorasExtras { get => montoHorasExtras; set => montoHorasExtras = value; }
        public float MontoHorasAuxente { get => montoHorasAuxente; set => montoHorasAuxente = value; }
        public float MontoOtrosDescuento { get => montoOtrosDescuento; set => montoOtrosDescuento = value; }
        public float MontoPorAdelanto { get => montoPorAdelanto; set => montoPorAdelanto = value; }
        public float MontoPorOtrosDescuentos { get => montoPorOtrosDescuentos; set => montoPorOtrosDescuentos = value; }
        public float MontoReingreso { get => montoReingreso; set => montoReingreso = value; }
        public Contrato Contrato { get => contrato; set => contrato = value; }
        public Periodo Periodo { get => periodo; set => periodo = value; }

        void CalcularTotalConceptoDescuento()
        {

        }

        void CalculatTotalConceptoIngreso()
        {

        }


    }
}
