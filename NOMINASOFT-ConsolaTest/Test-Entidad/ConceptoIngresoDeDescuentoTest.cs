using Capa._3_Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NOMINASOFT_ConsolaTest.Test_Entidad
{
    [TestClass]
    public class ConceptoIngresoDeDescuentoTest
    {
        [TestMethod]
        public void Test1_CalcularTotalConceptoDescuento()
        {
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();
            conceptoIngresoDeDescuento.MontoHorasAusente = 3;
            conceptoIngresoDeDescuento.MontoPorAdelanto = 3;
            conceptoIngresoDeDescuento.MontoOtrosDescuentos = 3;

            double TotalConceptoDescuento_esperado = 9;
            double TotalConceptoDescuento_obtenido = conceptoIngresoDeDescuento.CalcularTotalConceptoDescuento();
            Assert.AreEqual(TotalConceptoDescuento_esperado, TotalConceptoDescuento_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularTotalConceptoIngreso()
        {
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();

            conceptoIngresoDeDescuento.MontoHorasExtras = 2;
            conceptoIngresoDeDescuento.MontoReingreso = 2;
            conceptoIngresoDeDescuento.MontoOtrosIngresos = 2;

            double TotalConceptoIngreso_esperado = 6;
            double TotalConceptoIngreso_obtenido = conceptoIngresoDeDescuento.CalcularTotalConceptoIngreso();
            Assert.AreEqual(TotalConceptoIngreso_esperado, TotalConceptoIngreso_obtenido);
        }
    }
}
