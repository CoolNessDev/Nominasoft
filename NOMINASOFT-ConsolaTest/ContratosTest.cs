using Microsoft.VisualStudio.TestTools.UnitTesting;
using NOMINASOFT_Consola;
using System;

namespace NOMINASOFT_ConsolaTest
{
    [TestClass]
    public class ContratosTest
    {
        [TestMethod]
        public void Test1_CalcularMontoPorAsignacionFamiliar()
        {
            Contratos contratos = new Contratos();

            //Rellenar


            //--------

            double MontoPorAsignacionFamiliar_esperado = ;
            double MontoPorAsignacionFamiliar_obtenido = contratos.CalcularMontoPorAsignacionFamiliar();
            Assert.AreEqual(MontoPorAsignacionFamiliar_esperado, MontoPorAsignacionFamiliar_obtenido);

        }
        [TestMethod]
        public void Test1_ValidarFechaFinContrato()
        {
            Contratos contratos = new Contratos();

            //Rellenar


            //--------

            double FechaFinContrato_esperado = ;
            double FechaFinContrato_obtenido = contratos.ValidarFechaFinContrato();
            Assert.AreEqual(FechaFinContrato_esperado, FechaFinContrato_obtenido);
        }
        [TestMethod]
        public void Test1_ValidarFechaInicioContrato()
        {
            Contratos contratos = new Contratos();

            //Rellenar


            //--------

            double FechaInicioContrato_esperado = ;
            double FechaInicioContrato_obtenido = contratos.ValidarFechaInicioContrato();
            Assert.AreEqual(FechaInicioContrato_esperado, FechaInicioContrato_obtenido);
        }
        [TestMethod]
        public void Test1_ValidarHoras()
        {
            Contratos contratos = new Contratos();

            //Rellenar


            //--------

            double Horas_esperado = ;
            double Horas_obtenido = contratos.ValidarHoras();
            Assert.AreEqual(Horas_esperado, Horas_obtenido);
        }
        [TestMethod]
        public void Test1_ValidarValorHoras()
        {
            Contratos contratos = new Contratos();

            //Rellenar


            //--------

            double ValorHoras_esperado = ;
            double ValorHoras_obtenido = contratos.ValidarValorHoras();
            Assert.AreEqual(ValorHoras_esperado, ValorHoras_obtenido);
        }
        [TestMethod]
        public void Test1_ValidarVigenciaContrato()
        {
            Contratos contratos = new Contratos();

            //Rellenar


            //--------

            double VigenciaContrato_esperado = ;
            double VigenciaContrato_obtenido = contratos.ValidarVigenciaContrato();
            Assert.AreEqual(VigenciaContrato_esperado, VigenciaContrato_obtenido);
        }
    }
}
