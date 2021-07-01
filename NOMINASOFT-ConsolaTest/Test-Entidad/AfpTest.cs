using Capa._2_Aplicacion.Servicios;
using Capa._3_Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NOMINASOFT_ConsolaTest.Test_Entidad
{
    [TestClass]
    public class AfpTest
    {
        [TestMethod]
        public void ListarAfpTest()
        {
            GestionarContratos servicio = new GestionarContratos();
            List<Afp> afps = servicio.llenarComboBoxAFP();
            Assert.IsNotNull(afps);
        }
    }
}
