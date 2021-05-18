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

            //Rellenar


            //---------

            double TotalConceptoDescuento_esperado =  ;
            double TotalConceptoDescuento_obtenido = conceptoIngresoDeDescuento.CalcularTotalConceptoDescuento();
            Assert.AreEqual(TotalConceptoDescuento_esperado, TotalConceptoDescuento_obtenido);
        }
        [TestMethod]
        public void Test1_CalcularTotalConceptoIngreso()
        {
            ConceptoIngresoDeDescuento conceptoIngresoDeDescuento = new ConceptoIngresoDeDescuento();

            //Rellenar


            //---------

            double TotalConceptoIngreso_esperado = ;
            double TotalConceptoIngreso_obtenido = conceptoIngresoDeDescuento.CalcularTotalConceptoIngreso();
            Assert.AreEqual(TotalConceptoIngreso_esperado, TotalConceptoIngreso_obtenido);
        }
    }
}
