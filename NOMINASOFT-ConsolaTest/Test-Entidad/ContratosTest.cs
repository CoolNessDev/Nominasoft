using Capa._3_Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace NOMINASOFT_ConsolaTest.Test_Entidad
{
    [TestClass]
    public class ContratosTest
    {
        [TestMethod]
        public void Test1_ValidarFechaFinContrato()
        {
            Contrato contratos = new Contrato();
            contratos.FechaInicio = new DateTime(2021, 4, 16);
            contratos.FechaFin = new DateTime(2021, 8, 12);


            bool FechaFinContrato_esperado = true;
            bool FechaFinContrato_obtenido = contratos.ValidarFechaFinContrato();
            Assert.AreEqual(FechaFinContrato_esperado, FechaFinContrato_obtenido);
        }

        [TestMethod]
        public void Test1_ValidarFechaInicioContrato()
        {
            Contrato contratos = new Contrato();
            contratos.FechaInicio = new DateTime(2021, 5, 16);
            contratos.FechaFin = new DateTime(2021, 6, 15);

            Contrato contratosAnterior = new Contrato();
            contratosAnterior.FechaInicio = new DateTime(2021, 4, 16);
            contratosAnterior.FechaFin = new DateTime(2021, 5, 15);
            Empleado empleado = new Empleado();
            empleado.Contratos= new List<Contrato>();
            empleado.Contratos.Add(contratosAnterior);
            contratos.Empleado = empleado;

            bool FechaInicioContrato_esperado = true;
            bool FechaInicioContrato_obtenido = contratos.ValidarFechaInicioContrato();
            Assert.AreEqual(FechaInicioContrato_esperado, FechaInicioContrato_obtenido);
        }


        [TestMethod]
        public void Test1_ValidarHoras()
        {
            Contrato contratos = new Contrato();
            contratos.HorasContratadasPorSemana = 40;


            bool Horas_esperado = true;
            bool Horas_obtenido = contratos.ValidarHoras();
            Assert.AreEqual(Horas_esperado, Horas_obtenido);
        }

        [TestMethod]
        public void Test1_ValidarValorHoras()
        {
            Contrato contratos = new Contrato();
            contratos.ValorHora = 40;



            bool ValorHoras_esperado = true;
            bool ValorHoras_obtenido = contratos.ValidarValorHoras();
            Assert.AreEqual(ValorHoras_esperado, ValorHoras_obtenido);
        }

        [TestMethod]
        public void Test1_ValidarVigenciaContrato()
        {
            Contrato contratos = new Contrato();
            contratos.Estado = true;
            contratos.FechaFin = new DateTime(2021, 6, 15);
            //FechaActual
            contratos.FechaInicio = new DateTime(2021, 6, 15);


            bool VigenciaContrato_esperado = true;
            bool VigenciaContrato_obtenido = contratos.ValidarVigenciaContrato();
            Assert.AreEqual(VigenciaContrato_esperado, VigenciaContrato_obtenido);
        }
    }
}
