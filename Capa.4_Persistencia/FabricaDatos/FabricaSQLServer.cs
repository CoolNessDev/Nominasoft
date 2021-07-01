using Capa._3_Dominio.Contratos;
using Capa._3_Dominio.Pagos;
using Capa._3_Dominio.Servicios;
using Capa._4_Persistencia.ADO_SQLServer;

namespace Capa._4_Persistencia.FabricaDatos
{
    public class FabricaSqlServer : FabricaAbstracta
    {
        public override IAfp crearAfpDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new AfpSqlServer(gestorAccesoDatos);
        }
        public override IContrato crearContratoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new ContratoSqlServer(gestorAccesoDatos);
        }
        public override IEmpleado crearEmpleadoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new EmpleadoSqlServer(gestorAccesoDatos);
        }
        public override IPeriodo crearPeriodoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new PeriodoSqlServer(gestorAccesoDatos);
        }
        public override IPago crearPagoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new PagoSqlServer(gestorAccesoDatos);
        }
        public override IGestorAccesoDatos crearGestorAccesoDatos()
        {
            return new GestorSqlServer();
        }
    }
}
