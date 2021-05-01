using Capa._3_Dominio.Contratos;
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
        public override IAfp crearAfp(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new AfpSQLServer(gestorAccesoDatos);
        }
        public override IContrato crearContrato(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new ContratoSQLServer(gestorAccesoDatos);
        }
        public override IDescuento crearDescuento(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new DescuentoSQLServer(gestorAccesoDatos);
        }
        public override IEmpleado crearEmpleado(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new EmpleadoSQLServer(gestorAccesoDatos);
        }
        public override IIngreso crearIngreso(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new IngresoSQLServer(gestorAccesoDatos);
        }
        public override IPago crearPago(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new PagoSQLServer(gestorAccesoDatos);
        }
        public override IPeriodo crearPeriodo(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new PeriodoSQLServer(gestorAccesoDatos);
        }
        public override IRol crearRol(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new RolSQLServer(gestorAccesoDatos);
        }
    }
}
