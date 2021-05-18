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
            periodo.FechaFin = new DateTime(2021, 5, 17);
            periodo.FechaInicio = new DateTime(2021, 4, 16);
            /*
                 return (FechaFin - FechaInicio).TotalDays / 7;
             */

            Console.WriteLine("Difference in weeks: " + (periodo.FechaFin - periodo.FechaInicio).TotalDays / 7);
            double SemanasPeriodo_esperado = (periodo.FechaFin - periodo.FechaInicio).TotalDays / 7;
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
            /*
            if(FechaFin > FechaInicio && Estado)
            {
                return true;
            }
            return false;
                        */

            bool PeriodoActivo_esperado = (periodo.FechaFin > periodo.FechaInicio && periodo.Estado);
            bool PeriodoActivo_obtenido = periodo.ValidarPeriodoActivos();
            Assert.AreEqual(PeriodoActivo_esperado, PeriodoActivo_obtenido);
        }
    }
}
