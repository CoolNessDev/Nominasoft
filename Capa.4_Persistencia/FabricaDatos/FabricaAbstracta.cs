using Capa._3_Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._4_Persistencia.FabricaDatos
{
    public abstract class FabricaAbstracta
    {
        public static FabricaAbstracta crearInstancia()
        {
            //return new FabricaSQLServer();
            return new FabricaMySQL();
        }

        public abstract IAfp crearAfp(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IContrato crearContrato(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IDescuento crearDescuento(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IEmpleado crearEmpleado(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IIngreso crearIngreso(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IPago crearPago(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IPeriodo crearPeriodo(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IRol crearRol(IGestorAccesoDatos gestorAccesoDatos);

    }
}
