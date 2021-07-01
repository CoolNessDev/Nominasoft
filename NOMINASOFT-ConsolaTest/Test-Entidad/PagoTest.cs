using Capa._3_Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NOMINASOFT_ConsolaTest.Test_Entidad
{
    [TestClass]
    public class PagoTest
    {
        [TestMethod]
        public void Test1_CalcularSueldoBasico()
        {
            Pago pagos = new Pago();
            pagos.TotalHoras = 52;
            pagos.ValorHora = 30;

            decimal SueldoBasico_esperado = 1560;
            decimal SueldoBasico_obtenido = pagos.CalcularSueldoBasico();
            Assert.AreEqual(SueldoBasico_esperado, SueldoBasico_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularIngresoTotal()
        {
            Pago pagos = new Pago();
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();

            pagos.TotalHoras = 52;
            pagos.ValorHora = 30;

            pagos.MontoAsignacionFamiliar = 34;

            conceptoIngresoDeDescuento.MontoHorasExtras = 34;
            conceptoIngresoDeDescuento.MontoReingreso = 34;
            conceptoIngresoDeDescuento.MontoOtrosIngresos = 34;

            pagos.Contrato = new Contrato();
            pagos.Contrato.ConceptoIngresoDeDescuento = conceptoIngresoDeDescuento;



            decimal IngresoTotal_esperado = 1696;
            decimal IngresoTotal_obtenido = pagos.CalcularIngresoTotal();
            Assert.AreEqual(IngresoTotal_esperado, IngresoTotal_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularDescuentoAFP()
        {
            Pago pagos = new Pago();
            pagos.TotalHoras = 52;
            pagos.ValorHora = 30;

            pagos.PorcentajeDescuento = 18;



            decimal DescuentoAFP_obtenido = pagos.CalcularDescuentoAFP();
            Assert.AreEqual((decimal)280.8, DescuentoAFP_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularDescuentoTotal()
        {
            Pago pagos = new Pago();
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();

            pagos.TotalHoras = 52;
            pagos.ValorHora = 30;

            pagos.PorcentajeDescuento = 18;

            conceptoIngresoDeDescuento.MontoHorasAusente = 34;
            conceptoIngresoDeDescuento.MontoPorAdelanto = 34;
            conceptoIngresoDeDescuento.MontoOtrosDescuentos = 34;
            pagos.Contrato = new Contrato();
            pagos.Contrato.ConceptoIngresoDeDescuento = conceptoIngresoDeDescuento;

            decimal DescuentoTotal_obtenido = pagos.CalcularDescuentoTotal();
            Assert.AreEqual((decimal)382.8, DescuentoTotal_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularSueldoNeto()
        {
            Pago pagos = new Pago();
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();

            pagos.TotalHoras = 52;
            pagos.ValorHora = 30;

            pagos.MontoAsignacionFamiliar = 34;

            conceptoIngresoDeDescuento.MontoHorasExtras = 34;
            conceptoIngresoDeDescuento.MontoReingreso = 34;
            conceptoIngresoDeDescuento.MontoOtrosIngresos = 34;

            pagos.TotalHoras = 52;
            pagos.ValorHora = 30;

            pagos.PorcentajeDescuento = 18;

            conceptoIngresoDeDescuento.MontoHorasAusente = 34;
            conceptoIngresoDeDescuento.MontoPorAdelanto = 34;
            conceptoIngresoDeDescuento.MontoOtrosDescuentos = 34;

            pagos.Contrato = new Contrato();
            pagos.Contrato.ConceptoIngresoDeDescuento = conceptoIngresoDeDescuento;


            decimal SueldoNeto_obtenido = pagos.CalcularSueldoNeto();
            Assert.AreEqual((decimal)1313.2, SueldoNeto_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularTotalDeHoras()
        {
            Pago pagos = new Pago();
            Periodo periodo = new Periodo();
            pagos.Periodo = periodo;

            periodo.FechaFin = new DateTime(2021, 5, 17);
            periodo.FechaInicio = new DateTime(2021, 4, 16);

            pagos.TotalHoras = 48;

            decimal TotalDeHoras_obtenido = pagos.CalcularTotalDeHoras();
            Assert.AreEqual(48, TotalDeHoras_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularMontoPorAsignacionFamiliar()
        {
            Contrato contrato = new Contrato();
            Pago pagos = new Pago();

            contrato.AsignacionFamiliar = true;

            pagos.Contrato = contrato;
            pagos.SueldoMinimo = 930;


            decimal MontoPorAsignacionFamiliar_obtenido = pagos.CalcularMontoPorAsignacionFamiliar();
            Assert.AreEqual(93, MontoPorAsignacionFamiliar_obtenido);

        }
    }
}
