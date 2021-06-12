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
        private decimal montoAsignacionFamiliar;
        private decimal descuentAFP;
        private decimal sueldoMinimo;
        private decimal porcentajeDescuento;
        private decimal valorHora;
        private decimal totalHoras;
        private Periodo periodo;
        private Contrato contrato;
        public int Id_pago { get => id_pago; set => id_pago = value; }
        public DateTime FechaActual { get => fechaActual; set => fechaActual = value; }
        public decimal MontoAsignacionFamiliar { get => montoAsignacionFamiliar; set => montoAsignacionFamiliar = value; }
        public decimal DescuentAFP { get => descuentAFP; set => descuentAFP = value; }
        public decimal SueldoMinimo { get => sueldoMinimo; set => sueldoMinimo = value; }
        public decimal PorcentajeDescuento { get => porcentajeDescuento; set => porcentajeDescuento = value; }
        public decimal ValorHora { get => valorHora; set => valorHora = value; }
        public decimal TotalHoras { get => totalHoras; set => totalHoras = value; }
        public Periodo Periodo { get => periodo; set => periodo = value; }
        public Contrato Contrato { get => contrato; set => contrato = value; }



        public decimal CalcularMontoPorAsignacionFamiliar()
        {
            if (Periodo.Contratos[0].AsignacionFamiliar)
            {
                return SueldoMinimo * 0.10M;
            }
            return 0;
        }

        public decimal CalcularDescuentoTotal()
        {
            return Convert.ToDecimal(Periodo.ConceptoIngresoDeDescuento.CalcularTotalConceptoDescuento()) + CalcularDescuentoAFP();
        }

        public decimal CalcularDescuentoAFP()
        {
            return CalcularSueldoBasico() * (PorcentajeDescuento / 100);
        }


        public decimal CalcularIngresoTotal()
        {
            return CalcularSueldoBasico() + MontoAsignacionFamiliar + Convert.ToDecimal(Periodo.ConceptoIngresoDeDescuento.CalcularTotalConceptoIngreso());
        }

        public decimal CalcularSueldoBasico()
        {
            return TotalHoras * ValorHora;
        }

        public decimal CalcularSueldoNeto()
        {
            return CalcularIngresoTotal() - CalcularDescuentoTotal();
        }

        public decimal CalcularTotalDeHoras()
        {
            return Periodo.CalcularSemanasPeriodo() * Contrato.HorasContratadasPorSemana;
        }
    }
}
