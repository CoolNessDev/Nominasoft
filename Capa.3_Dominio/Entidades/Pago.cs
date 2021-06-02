using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Pago
    {
        private int id_pago;
        private DateTime fechaActual;
        private float montoAsignacionFamiliar;
        private float descuentAFP;
        private float sueldoMinimo;
        private float porcentajeDescuento;
        private float valorHora;
        private float totalHoras;

        private ConceptoIngresoDeDescuento conceptoIngresoDeDescuento;
        private Periodo periodo;
        private Contrato contrato;
        public int Id_pago { get => id_pago; set => id_pago = value; }
        public DateTime FechaActual { get => fechaActual; set => fechaActual = value; }
        public float MontoAsignacionFamiliar { get => montoAsignacionFamiliar; set => montoAsignacionFamiliar = value; }
        public float DescuentAFP { get => descuentAFP; set => descuentAFP = value; }
        public float SueldoMinimo { get => sueldoMinimo; set => sueldoMinimo = value; }
        public float PorcentajeDescuento { get => porcentajeDescuento; set => porcentajeDescuento = value; }
        public float ValorHora { get => valorHora; set => valorHora = value; }
        public float TotalHoras { get => totalHoras; set => totalHoras = value; }
        public ConceptoIngresoDeDescuento ConceptoIngresoDeDescuento { get => conceptoIngresoDeDescuento; set => conceptoIngresoDeDescuento = value; }
        public Periodo Periodo { get => periodo; set => periodo = value; }
        public Contrato Contrato { get => contrato; set => contrato = value; }

        public double CalcularMontoPorAsignacionFamiliar()
        {
            if (contrato.AsignacionFamiliar)
            {
                return SueldoMinimo * 0.1;
            }
            return 0;
        }

        public double CalcularDescuentoTotal()
        {
            return ConceptoIngresoDeDescuento.CalcularTotalConceptoDescuento() + CalcularDescuentoAFP();
        }

        public double CalcularDescuentoAFP()
        {
            return CalcularSueldoBasico() * (PorcentajeDescuento / 100);
        }


        public double CalcularIngresoTotal()
        {
            return CalcularSueldoBasico() + MontoAsignacionFamiliar + ConceptoIngresoDeDescuento.CalcularTotalConceptoIngreso();
        }

        public double CalcularSueldoBasico()
        {
            return TotalHoras * ValorHora;
        }

        public double CalcularSueldoNeto()
        {
            return CalcularIngresoTotal() - CalcularDescuentoTotal();
        }

        public double CalcularTotalDeHoras()
        {
            return Periodo.CalcularSemanasPeriodo() * TotalHoras;
        }
    }
}
