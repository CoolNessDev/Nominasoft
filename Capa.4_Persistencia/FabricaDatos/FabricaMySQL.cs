using Capa._3_Dominio.Contratos;
using Capa._4_Persistencia.ADO_MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._4_Persistencia.FabricaDatos
{
    public class FabricaMySQL : FabricaAbstracta
    {
        public override IAfp crearAfp(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new AfpMySQL(gestorAccesoDatos);
        }
        public override IContrato crearContrato(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new ContratoMySQL(gestorAccesoDatos);
        }
        public override IDescuento crearDescuento(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new DescuentoMySQL(gestorAccesoDatos);
        }
        public override IEmpleado crearEmpleado(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new EmpleadoMySQL(gestorAccesoDatos);
        }
        public override IIngreso crearIngreso(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new IngresoMySQL(gestorAccesoDatos);
        }
        public override IPago crearPago(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new PagoMySQL(gestorAccesoDatos);
        }
        public override IPeriodo crearPeriodo(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new PeriodoMySQL(gestorAccesoDatos);
        }
        public override IRol crearRol(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new RolMySQL(gestorAccesoDatos);
        }
    }
}
