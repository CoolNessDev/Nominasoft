using Capa._3_Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NOMINASOFT_ConsolaTest.Test_Entidad
{
    [TestClass]
    public class ContratosTest
    {
        [TestMethod]
        public void Test1_ValidarFechaFinContrato()
        {
            Contrato contratos = new Contrato();
            contratos.FechaFin = new DateTime(2021, 8, 12);
            contratos.FechaInicio = new DateTime(2021, 4, 16);


            bool FechaFinContrato_esperado = true;
            bool FechaFinContrato_obtenido = contratos.ValidarFechaFinContrato();
            Assert.AreEqual(FechaFinContrato_esperado, FechaFinContrato_obtenido);
        }

        [TestMethod]
        public void Test2_ValidarFechaFinContrato()
        {
            Contrato contratos = new Contrato();
            contratos.FechaFin = new DateTime(2021, 8, 12);
            contratos.FechaInicio = new DateTime(2021, 7, 16);

  
            bool FechaFinContrato_esperado = false;
            bool FechaFinContrato_obtenido = contratos.ValidarFechaFinContrato();
            Assert.AreEqual(FechaFinContrato_esperado, FechaFinContrato_obtenido);
        }

        [TestMethod]
        public void Test1_ValidarFechaInicioContrato()
        {
            Contrato contratos = new Contrato();
            contratos.FechaInicio = new DateTime(2021, 4, 16);
            //FechaFinAnterior
            contratos.FechaFin = new DateTime(2021, 4, 15);
 
            bool FechaInicioContrato_esperado = true;
            bool FechaInicioContrato_obtenido = contratos.ValidarFechaInicioContrato();
            Assert.AreEqual(FechaInicioContrato_esperado, FechaInicioContrato_obtenido);
        }

        [TestMethod]
        public void Test2_ValidarFechaInicioContrato()
        {
            Contrato contratos = new Contrato();
            contratos.FechaInicio = new DateTime(2021, 4, 16);
            //FechaFinAnterior
            contratos.FechaFin = new DateTime(2021, 5, 18);
 
            bool FechaInicioContrato_esperado = false;
            bool FechaInicioContrato_obtenido = contratos.ValidarFechaInicioContrato();
            Assert.AreEqual(FechaInicioContrato_esperado, FechaInicioContrato_obtenido);
        }

        [TestMethod]
        public void Test1_ValidarHoras()
        {
            Contrato contratos = new Contrato();
            contratos.HorasContratadasPorSemana = 12;


            bool Horas_esperado = true;
            bool Horas_obtenido = contratos.ValidarHoras();
            Assert.AreEqual(Horas_esperado, Horas_obtenido);
        }

        [TestMethod]
        public void Test2_ValidarHoras()
        {
            Contrato contratos = new Contrato();
            contratos.HorasContratadasPorSemana = 11;

  

            bool Horas_esperado = false;
            bool Horas_obtenido = contratos.ValidarHoras();
            Assert.AreEqual(Horas_esperado, Horas_obtenido);
        }

        [TestMethod]
        public void Test1_ValidarValorHoras()
        {
            Contrato contratos = new Contrato();
            contratos.ValorHora = 20;



            bool ValorHoras_esperado = true;
            bool ValorHoras_obtenido = contratos.ValidarValorHoras();
            Assert.AreEqual(ValorHoras_esperado, ValorHoras_obtenido);
        }

        [TestMethod]
        public void Test2_ValidarValorHoras()
        {
            Contrato contratos = new Contrato();
            contratos.ValorHora = 9;


            bool ValorHoras_esperado = false;
            bool ValorHoras_obtenido = contratos.ValidarValorHoras();
            Assert.AreEqual(ValorHoras_esperado, ValorHoras_obtenido);
        }

        [TestMethod]
        public void Test1_ValidarVigenciaContrato()
        {
            Contrato contratos = new Contrato();
            contratos.Estado = true;
            contratos.FechaFin = new DateTime(2021, 8, 15);
            //FechaActual
            contratos.FechaInicio = new DateTime(2021, 6, 15);


            bool VigenciaContrato_esperado = true;
            bool VigenciaContrato_obtenido = contratos.ValidarVigenciaContrato();
            Assert.AreEqual(VigenciaContrato_esperado, VigenciaContrato_obtenido);
        }

        [TestMethod]
        public void Test2_ValidarVigenciaContrato()
        {
            Contrato contratos = new Contrato();
            contratos.Estado = true;
            contratos.FechaFin = new DateTime(2021, 8, 15);
            //FechaActual
            contratos.FechaInicio = new DateTime(2021, 10, 15);

            bool VigenciaContrato_esperado = false;
            bool VigenciaContrato_obtenido = contratos.ValidarVigenciaContrato();
            Assert.AreEqual(VigenciaContrato_esperado, VigenciaContrato_obtenido);
        }
    }
}
