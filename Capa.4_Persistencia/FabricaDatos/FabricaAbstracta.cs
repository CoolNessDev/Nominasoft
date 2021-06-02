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
            return new FabricaSQLServer();
        }
        public abstract IGestorAccesoDatos crearGestorAccesoDatos();
        public abstract IAfp crearAfpDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IContrato crearContratoDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IEmpleado crearEmpleadoDAO(IGestorAccesoDatos gestorAccesoDatos);

    }
}
