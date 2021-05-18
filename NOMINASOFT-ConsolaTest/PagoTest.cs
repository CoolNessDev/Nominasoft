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

            //Rellenar

            //--------

            double DescuentoAFP_esperado = ;
            double DescuentoAFP_obtenido = pagos.CalcularDescuentoAFP();
            Assert.AreEqual(DescuentoAFP_esperado, DescuentoAFP_obtenido);

        }
        [TestMethod]
        public void Test1_CalcularDescuentoTotal()
        {
            Pagos pagos = new Pagos();

            //Rellenar

            //--------

            double DescuentoTotal_esperado = ;
            double DescuentoTotal_obtenido = pagos.CalcularDescuentoTotal();
            Assert.AreEqual(DescuentoTotal_esperado, DescuentoTotal_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularIngresoTotal()
        {
            Pagos pagos = new Pagos();

            //Rellenar

            //--------

            double IngresoTotal_esperado = ;
            double IngresoTotal_obtenido = pagos.CalcularIngresoTotal();
            Assert.AreEqual(IngresoTotal_esperado, IngresoTotal_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularSueldoBasico()
        {
            Pagos pagos = new Pagos();

            //Rellenar

            //--------

            double SueldoBasico_esperado = ;
            double SueldoBasico_obtenido = pagos.CalcularSueldoBasico();
            Assert.AreEqual(SueldoBasico_esperado, SueldoBasico_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularSueldoNeto()
        {
            Pagos pagos = new Pagos();

            //Rellenar

            //--------

            double SueldoNeto_esperado = ;
            double SueldoNeto_obtenido = pagos.CalcularSueldoNeto();
            Assert.AreEqual(SueldoNeto_esperado, SueldoNeto_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularTotalDeHoras()
        {
            Pagos pagos = new Pagos();

            //Rellenar

            //--------

            double TotalDeHoras_esperado = ;
            double TotalDeHoras_obtenido = pagos.CalcularTotalDeHoras();
            Assert.AreEqual(TotalDeHoras_esperado, TotalDeHoras_obtenido);
        }
    }
}
