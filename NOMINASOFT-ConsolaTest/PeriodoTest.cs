using Microsoft.VisualStudio.TestTools.UnitTesting;
using NOMINASOFT_Consola;
using System;

namespace NOMINASOFT_ConsolaTest
{
    [TestClass]
    public class PeriodoTest
    {
        [TestMethod]
        public void Test1_CalcularSemanasPeriodos()
        {
            Periodo periodo = new Periodo();

            //Rellenar

            //--------

            double SemanasPeriodo_esperado = ;
            double SemanasPeriodo_obtenido = periodo.CalcularSemanasPeriodos();
            Assert.AreEqual(SemanasPeriodo_esperado, SemanasPeriodo_obtenido);

        }
        [TestMethod]
        public void Test1_ValidarPeriodoActivo()
        {
            Periodo periodo = new Periodo();

            //Rellenar

            //--------

            double PeriodoActivo_esperado = ;
            double PeriodoActivo_obtenido = periodo.ValidarPeriodoActivos();
            Assert.AreEqual(PeriodoActivo_esperado, PeriodoActivo_obtenido);
        }
    }
}
