using Microsoft.VisualStudio.TestTools.UnitTesting;
using NOMINASOFT_Consola;
using System;

namespace NOMINASOFT_ConsolaTest
{
    [TestClass]
    public class ConceptoIngresoDeDescuentoTest
    {
        [TestMethod]
        public void Test1_CalcularTotalConceptoDescuento()
        {
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();
            conceptoIngresoDeDescuento.MontoHorasAusente = 3.2f;
            conceptoIngresoDeDescuento.MontoPorAdelanto = 3.2f;
            conceptoIngresoDeDescuento.MontoOtrosDescuentos = 3.2f;
            //MontoHorasAusente + MontoPorAdelanto + MontoOtrosDescuentos;

            double TotalConceptoDescuento_esperado = conceptoIngresoDeDescuento.MontoHorasAusente + conceptoIngresoDeDescuento.MontoPorAdelanto +
                conceptoIngresoDeDescuento.MontoOtrosDescuentos;
            double TotalConceptoDescuento_obtenido = conceptoIngresoDeDescuento.CalcularTotalConceptoDescuento();
            Assert.AreEqual(TotalConceptoDescuento_esperado, TotalConceptoDescuento_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularTotalConceptoIngreso()
        {
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();
            conceptoIngresoDeDescuento.MontoHorasExtras = 2.3f;
            conceptoIngresoDeDescuento.MontoReingreso = 2.3f;
            conceptoIngresoDeDescuento.MontoOtrosIngresos = 2.3f;

            //return MontoHorasExtras + MontoReingreso + MontoOtrosIngresos;


            double TotalConceptoIngreso_esperado = conceptoIngresoDeDescuento.MontoHorasExtras + conceptoIngresoDeDescuento.MontoReingreso +
                conceptoIngresoDeDescuento.MontoOtrosIngresos;
            double TotalConceptoIngreso_obtenido = conceptoIngresoDeDescuento.CalcularTotalConceptoIngreso();
            Assert.AreEqual(TotalConceptoIngreso_esperado, TotalConceptoIngreso_obtenido);
        }
    }
}
