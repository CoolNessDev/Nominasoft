using Capa._3_Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NOMINASOFT_ConsolaTest.Test_Entidad
{
    [TestClass]
    public class PeriodoTest
    {
        [TestMethod]
        public void Test1_CalcularSemanasPeriodos()
        {
            Periodo periodo = new Periodo();

            periodo.FechaFin = new DateTime(2021, 5, 17);
            periodo.FechaInicio = new DateTime(2021, 4, 16);



            double SemanasPeriodo_esperado = 4;
            double SemanasPeriodo_obtenido = periodo.CalcularSemanasPeriodo();
            Assert.AreEqual(SemanasPeriodo_esperado, SemanasPeriodo_obtenido);
        }

        [TestMethod]
        public void Test1_ValidarPeriodoActivo()
        {
            Periodo periodo = new Periodo();
            periodo.FechaFin = new DateTime(2021, 6, 16);
            periodo.FechaInicio = new DateTime(2021, 4, 16);
            periodo.Estado = true;


            bool PeriodoActivo_esperado = true;
            bool PeriodoActivo_obtenido = periodo.ValidarPeriodoActivos();
            Assert.AreEqual(PeriodoActivo_esperado, PeriodoActivo_obtenido);
        }

        [TestMethod]
        public void Test2_ValidarPeriodoActivo()
        {
            Periodo periodo = new Periodo();
            periodo.FechaFin = new DateTime(2021, 6, 16);
            periodo.FechaInicio = new DateTime(2021, 4, 16);
            periodo.Estado = false;

            bool PeriodoActivo_esperado = false;
            bool PeriodoActivo_obtenido = periodo.ValidarPeriodoActivos();
            Assert.AreEqual(PeriodoActivo_esperado, PeriodoActivo_obtenido);
        }
    }
}
