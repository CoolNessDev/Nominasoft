using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOMINASOFT_Consola
{
    public class Pagos
    {
        private int id_pago;
        private DateTime fechaActual;
        private float asignacionFamiliar;
        private float descuentAFP;
        private float sueldoMinimo;
        private float porsentajeDescuento;
        private float ValorHora;
        private float totalHoras;


        private ConceptoIngresoDeDescuento conceptoIngresoDeDescuento;

        public int Id_pago { get => id_pago; set => id_pago = value; }
        public DateTime FechaActual { get => fechaActual; set => fechaActual = value; }
        public float AsignacionFamiliar { get => asignacionFamiliar; set => asignacionFamiliar = value; }
        public float DescuentAFP { get => descuentAFP; set => descuentAFP = value; }
        public float SueldoMinimo { get => sueldoMinimo; set => sueldoMinimo = value; }
        public float PorsentajeDescuento { get => porsentajeDescuento; set => porsentajeDescuento = value; }
        public float ValorHora1 { get => ValorHora; set => ValorHora = value; }
        public float TotalHoras { get => totalHoras; set => totalHoras = value; }
        public ConceptoIngresoDeDescuento ConceptoIngresoDeDescuento { get => conceptoIngresoDeDescuento; set => conceptoIngresoDeDescuento = value; }


        public double CalcularDescuentoTotal(float MontoOtrosDescuento)
        {
            return MontoOtrosDescuento + DescuentAFP;
        }

        public double CalcularDescuentoAFP(float porcentajeDescuento)
        {
            return SueldoMinimo * porcentajeDescuento;
        }


        public double CalcularIngresoTotal(float montoPorAsignacion, float totalConceptosIngreso)
        {
            return SueldoMinimo + montoPorAsignacion + totalConceptosIngreso;
        }

        public double CalcularSueldoBasico()
        {
            return TotalHoras * ValorHora1;
        }


        public double CalcularSueldoNeto(float totalIngresos, float totalDescuentos)
        {
            return totalIngresos - totalDescuentos;
        }

        public double CalcularTotalDeHoras(double totalSemanasPeriodo, float totalHorasSemana)
        {
            return totalSemanasPeriodo * totalHorasSemana;
        }
    }
}
