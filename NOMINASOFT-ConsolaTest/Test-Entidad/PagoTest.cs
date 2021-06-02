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
  
            double SueldoBasico_esperado = 1560;
            double SueldoBasico_obtenido = pagos.CalcularSueldoBasico();
            Assert.AreEqual(SueldoBasico_esperado, SueldoBasico_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularIngresoTotal()
        {
            Pago pagos = new Pago();
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();
            pagos.ConceptoIngresoDeDescuento = conceptoIngresoDeDescuento;

            pagos.TotalHoras = 52;
            pagos.ValorHora = 30;

            pagos.MontoAsignacionFamiliar = 34;

            conceptoIngresoDeDescuento.MontoHorasExtras = 34;
            conceptoIngresoDeDescuento.MontoReingreso = 34;
            conceptoIngresoDeDescuento.MontoOtrosIngresos = 34;



            double IngresoTotal_esperado = 1696;
            double IngresoTotal_obtenido = pagos.CalcularIngresoTotal();
            Assert.AreEqual(IngresoTotal_esperado, IngresoTotal_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularDescuentoAFP()
        {
            Pago pagos = new Pago();
            pagos.TotalHoras = 52;
            pagos.ValorHora = 30;

            pagos.PorcentajeDescuento = 18;



            double DescuentoAFP_esperado = 280.8;
            double DescuentoAFP_obtenido = pagos.CalcularDescuentoAFP();
            Assert.AreEqual(DescuentoAFP_esperado, DescuentoAFP_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularDescuentoTotal()
        {
            Pago pagos = new Pago();
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();
            pagos.ConceptoIngresoDeDescuento = conceptoIngresoDeDescuento;

            pagos.TotalHoras = 52;
            pagos.ValorHora = 30;

            pagos.PorcentajeDescuento = 18;

            conceptoIngresoDeDescuento.MontoHorasAusente = 34;
            conceptoIngresoDeDescuento.MontoPorAdelanto = 34;
            conceptoIngresoDeDescuento.MontoOtrosDescuentos = 34;

            double DescuentoTotal_esperado = 382.8;
            double DescuentoTotal_obtenido = pagos.CalcularDescuentoTotal();
            Assert.AreEqual(DescuentoTotal_esperado, DescuentoTotal_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularSueldoNeto()
        {
            Pago pagos = new Pago();
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();
            pagos.ConceptoIngresoDeDescuento = conceptoIngresoDeDescuento;

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

            double SueldoNeto_esperado = 1313.2;
            double SueldoNeto_obtenido = pagos.CalcularSueldoNeto();
            Assert.AreEqual(SueldoNeto_esperado, SueldoNeto_obtenido);
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

            double TotalDeHoras_esperado = 192;
            double TotalDeHoras_obtenido = pagos.CalcularTotalDeHoras();
            Assert.AreEqual(TotalDeHoras_esperado, TotalDeHoras_obtenido);
        }

        [TestMethod]
        public void Test1_CalcularMontoPorAsignacionFamiliar()
        {
            Contrato contrato = new Contrato();
            Pago pagos = new Pago();
            pagos.Contrato = contrato;

            contrato.AsignacionFamiliar = true;

            pagos.SueldoMinimo = 930;


            double MontoPorAsignacionFamiliar_esperado = 93;
            double MontoPorAsignacionFamiliar_obtenido = pagos.CalcularMontoPorAsignacionFamiliar();
            Assert.AreEqual(MontoPorAsignacionFamiliar_esperado, MontoPorAsignacionFamiliar_obtenido);

        }

        [TestMethod]
        public void Test2_CalcularMontoPorAsignacionFamiliar()
        {
            Contrato contrato = new Contrato();
            Pago pagos = new Pago();
            pagos.Contrato = contrato;

            contrato.AsignacionFamiliar = false;

            pagos.SueldoMinimo = 930;



            double MontoPorAsignacionFamiliar_esperado = 0;
            double MontoPorAsignacionFamiliar_obtenido = pagos.CalcularMontoPorAsignacionFamiliar();
            Assert.AreEqual(MontoPorAsignacionFamiliar_esperado, MontoPorAsignacionFamiliar_obtenido);

        }
    }
}
