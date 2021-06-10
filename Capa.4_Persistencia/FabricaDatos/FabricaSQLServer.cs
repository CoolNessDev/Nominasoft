using Capa._3_Dominio.Contratos;
using Capa._3_Dominio.Pagos;
using Capa._3_Dominio.Servicios;
using Capa._4_Persistencia.ADO_SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._4_Persistencia.FabricaDatos
{
    public class FabricaSQLServer : FabricaAbstracta
    {
        public override IAfp crearAfpDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new AfpSQLServer(gestorAccesoDatos);
        }
        public override IContrato crearContratoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new ContratoSQLServer(gestorAccesoDatos);
        }
        public override IEmpleado crearEmpleadoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new EmpleadoSQLServer(gestorAccesoDatos);
        }
        public override IPeriodo crearPeriodoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new PeriodoSQLServer(gestorAccesoDatos);
        }
        public override IPago crearPagoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new PagoSQLServer(gestorAccesoDatos);
        }
        public override IGestorAccesoDatos crearGestorAccesoDatos()
        {
            return new GestorSQLServer();
        }
    }
}
