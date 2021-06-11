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
        private double montoAsignacionFamiliar;
        private double descuentAFP;
        private double sueldoMinimo;
        private decimal porcentajeDescuento;
        private double valorHora;
        private double totalHoras;
        private Periodo periodo;
        private Contrato contrato;
        public int Id_pago { get => id_pago; set => id_pago = value; }
        public DateTime FechaActual { get => fechaActual; set => fechaActual = value; }
        public double MontoAsignacionFamiliar { get => montoAsignacionFamiliar; set => montoAsignacionFamiliar = value; }
        public double DescuentAFP { get => descuentAFP; set => descuentAFP = value; }
        public double SueldoMinimo { get => sueldoMinimo; set => sueldoMinimo = value; }
        public decimal PorcentajeDescuento { get => porcentajeDescuento; set => porcentajeDescuento = value; }
        public double ValorHora { get => valorHora; set => valorHora = value; }
        public double TotalHoras { get => totalHoras; set => totalHoras = value; }
        public Periodo Periodo { get => periodo; set => periodo = value; }
        public Contrato Contrato { get => contrato; set => contrato = value; }



        public double CalcularMontoPorAsignacionFamiliar()
        {
            if (Periodo.Contratos[0].AsignacionFamiliar)
            {
                return SueldoMinimo * 0.1;
            }
            return 0;
        }

        public double CalcularDescuentoTotal()
        {
            return Periodo.ConceptoIngresoDeDescuento.CalcularTotalConceptoDescuento() + CalcularDescuentoAFP();
        }

        public double CalcularDescuentoAFP()
        {
            return CalcularSueldoBasico() * Convert.ToDouble((PorcentajeDescuento / 100));
        }


        public double CalcularIngresoTotal()
        {
            return CalcularSueldoBasico() + MontoAsignacionFamiliar + Periodo.ConceptoIngresoDeDescuento.CalcularTotalConceptoIngreso();
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
            return Periodo.CalcularSemanasPeriodo() * Contrato.HorasContratadasPorSemana;
        }
    }
}
