using Microsoft.VisualStudio.TestTools.UnitTesting;
using NOMINASOFT_Consola;
using System;

namespace NOMINASOFT_ConsolaTest
{
    [TestClass]
    public class PagoTest
    {
        [TestMethod]
        public void Test1_CalcularDescuentoAFP()
        {
            Pagos pagos = new Pagos();
            pagos.SueldoMinimo = 930.4f;
            float porcentajeDescuento = 0.18f;
            /*
             return SueldoMinimo * porcentajeDescuento;
             */

            double DescuentoAFP_esperado = pagos.SueldoMinimo * porcentajeDescuento;
            double DescuentoAFP_obtenido = pagos.CalcularDescuentoAFP(porcentajeDescuento);
            Assert.AreEqual(DescuentoAFP_esperado, DescuentoAFP_obtenido);

        }
        [TestMethod]
        public void Test1_CalcularDescuentoTotal()
        {
            Pagos pagos = new Pagos();
            pagos.DescuentAFP = 34.4f;
            float MontoOtrosDescuento = 102;
            /*
            return MontoOtrosDescuento + DescuentAFP;
             */

            double DescuentoTotal_esperado = MontoOtrosDescuento + pagos.DescuentAFP;
            double DescuentoTotal_obtenido = pagos.CalcularDescuentoTotal(MontoOtrosDescuento);
            Assert.AreEqual(DescuentoTotal_esperado, DescuentoTotal_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularIngresoTotal()
        {
            Pagos pagos = new Pagos();
            pagos.SueldoMinimo = 930.4f;
            float montoPorAsignacion = 34;
            float totalConceptosIngreso = 102;
            /*
            return SueldoMinimo + montoPorAsignacion + totalConceptosIngreso;
             */

            double IngresoTotal_esperado = pagos.SueldoMinimo + montoPorAsignacion + totalConceptosIngreso;
            double IngresoTotal_obtenido = pagos.CalcularIngresoTotal(montoPorAsignacion, totalConceptosIngreso);
            Assert.AreEqual(IngresoTotal_esperado, IngresoTotal_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularSueldoBasico()
        {
            Pagos pagos = new Pagos();
            pagos.TotalHoras = 52;
            pagos.ValorHora1 = 30;
            /*
            return TotalHoras * ValorHora1;
             */

            double SueldoBasico_esperado = pagos.TotalHoras * pagos.ValorHora1;
            double SueldoBasico_obtenido = pagos.CalcularSueldoBasico();
            Assert.AreEqual(SueldoBasico_esperado, SueldoBasico_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularSueldoNeto()
        {
            Pagos pagos = new Pagos();
            float totalIngresos = 1003;
            float totalDescuentos = 102;

            /*
             return totalIngresos - totalDescuentos;
            */

            double SueldoNeto_esperado = totalIngresos - totalDescuentos;
            double SueldoNeto_obtenido = pagos.CalcularSueldoNeto(totalIngresos, totalDescuentos);
            Assert.AreEqual(SueldoNeto_esperado, SueldoNeto_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularTotalDeHoras()
        {
            Pagos pagos = new Pagos();
            double totalSemanasPeriodo = 4.332;
            float totalHorasSemana = 48;
            /*
             return totalSemanasPeriodo * totalHorasSemana;
            */

            double TotalDeHoras_esperado = totalSemanasPeriodo * totalHorasSemana;
            double TotalDeHoras_obtenido = pagos.CalcularTotalDeHoras(totalSemanasPeriodo, totalHorasSemana);
            Assert.AreEqual(TotalDeHoras_esperado, TotalDeHoras_obtenido);
        }
    }
}
