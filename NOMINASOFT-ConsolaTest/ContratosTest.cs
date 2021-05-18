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
            contratos.AsignacionFamiliar = true;
            float sueldoMinimo = 930;

            /*
             if (AsignacionFamiliar)
            {
                return sueldoMinimo * 0.1;
            }
            return 0;
             */

            double MontoPorAsignacionFamiliar_esperado = contratos.AsignacionFamiliar? sueldoMinimo * 0.1 : 0;
            double MontoPorAsignacionFamiliar_obtenido = contratos.CalcularMontoPorAsignacionFamiliar(sueldoMinimo);
            Assert.AreEqual(MontoPorAsignacionFamiliar_esperado, MontoPorAsignacionFamiliar_obtenido);

        }
        [TestMethod]
        public void Test1_ValidarFechaFinContrato()
        {
            Contratos contratos = new Contratos();
            contratos.FechaFin = new DateTime(2021,8,12);
            contratos.FechaInicio = new DateTime(2021,4,16);

            /*
              if ((FechaFin - FechaInicio).TotalDays > 90 && (FechaFin - FechaInicio).TotalDays < 365)
            {
                return true;
            }
            return false;
            */

            bool FechaFinContrato_esperado = ((contratos.FechaFin - contratos.FechaInicio).TotalDays > 90 && (contratos.FechaFin - contratos.FechaInicio).TotalDays < 365);
            bool FechaFinContrato_obtenido = contratos.ValidarFechaFinContrato();
            Assert.AreEqual(FechaFinContrato_esperado, FechaFinContrato_obtenido);
        }
        [TestMethod]
        public void Test1_ValidarFechaInicioContrato()
        {
            Contratos contratos = new Contratos();
            contratos.FechaInicio = new DateTime(2021, 4, 16);
            /*
             if (FechaInicio > FechaFinAnterior)
            {
                return true;
            }
            return false;
            */
            DateTime fechaFinAnterior = new  DateTime(2021, 4, 15);
            bool FechaInicioContrato_esperado = (contratos.FechaInicio > fechaFinAnterior);
            bool FechaInicioContrato_obtenido = contratos.ValidarFechaInicioContrato(fechaFinAnterior);
            Assert.AreEqual(FechaInicioContrato_esperado, FechaInicioContrato_obtenido);
        }
        [TestMethod]
        public void Test1_ValidarHoras()
        {
            Contratos contratos = new Contratos();
            contratos.HorasContratadasPorSemana = 4;

            /*
             if (8<HorasContratadasPorSemana && HorasContratadasPorSemana<40 && HorasContratadasPorSemana%4==0)
            {
                return true;
            }
            return false;
            */

            bool Horas_esperado = (8 < contratos.HorasContratadasPorSemana && contratos.HorasContratadasPorSemana < 40 && contratos.HorasContratadasPorSemana % 4 == 0);
            bool Horas_obtenido = contratos.ValidarHoras();
            Assert.AreEqual(Horas_esperado, Horas_obtenido);
        }
        [TestMethod]
        public void Test1_ValidarValorHoras()
        {
            Contratos contratos = new Contratos();
            contratos.ValorHora = 20;

            /*
            if(10<ValorHora && ValorHora < 60 && ValorHora-(int)ValorHora==0)
            {
                return true;
            }
            return false;
             */

            bool ValorHoras_esperado = (10 < contratos.ValorHora && contratos.ValorHora < 60 && contratos.ValorHora - (int)contratos.ValorHora == 0);
            bool ValorHoras_obtenido = contratos.ValidarValorHoras();
            Assert.AreEqual(ValorHoras_esperado, ValorHoras_obtenido);
        }
        [TestMethod]
        public void Test1_ValidarVigenciaContrato()
        {
            Contratos contratos = new Contratos();
            contratos.Estado = true;
            contratos.FechaFin = new DateTime(2021, 8, 15);
            DateTime currentDate = new DateTime();
            /*
            if(FechaFin>= currentDate && Estado)
            {
                return true;
            }
            return false;
             */

            bool VigenciaContrato_esperado = (contratos.FechaFin >= currentDate && contratos.Estado);
            bool VigenciaContrato_obtenido = contratos.ValidarVigenciaContrato();
            Assert.AreEqual(VigenciaContrato_esperado, VigenciaContrato_obtenido);
        }
    }
}
