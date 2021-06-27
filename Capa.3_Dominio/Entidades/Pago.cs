using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Pago
    {
        public int Id_pago { get; set; }
        public DateTime FechaActual { get; set; }
        public decimal MontoAsignacionFamiliar { get; set; }
        public decimal DescuentAFP { get; set; }
        public decimal SueldoMinimo { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal ValorHora { get; set; }
        public decimal TotalHoras { get; set; }
        public Periodo Periodo { get; set; }
        public Contrato Contrato { get; set; }



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
            if (Contrato.ConceptoIngresoDeDescuento != null)
            {
                return Convert.ToDecimal(Contrato.ConceptoIngresoDeDescuento.CalcularTotalConceptoDescuento()) + CalcularDescuentoAFP();
            }
            return CalcularDescuentoAFP();
        }

        public decimal CalcularDescuentoAFP()
        {
            return CalcularSueldoBasico() * (PorcentajeDescuento / 100);
        }


        public decimal CalcularIngresoTotal()
        {
            if (Contrato.ConceptoIngresoDeDescuento != null)
            {
                return CalcularSueldoBasico() + MontoAsignacionFamiliar + Convert.ToDecimal(Contrato.ConceptoIngresoDeDescuento.CalcularTotalConceptoIngreso());
            }
            return CalcularSueldoBasico() + MontoAsignacionFamiliar;
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
