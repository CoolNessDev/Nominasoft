using Capa._3_Dominio.Contratos;
using Capa._3_Dominio.Pagos;
using Capa._3_Dominio.Servicios;

namespace Capa._4_Persistencia.FabricaDatos
{
    public abstract class FabricaAbstracta
    {
        public static FabricaAbstracta crearInstancia()
        {
            return new FabricaSqlServer();
        }
        public abstract IGestorAccesoDatos crearGestorAccesoDatos();
        public abstract IAfp crearAfpDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IContrato crearContratoDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IEmpleado crearEmpleadoDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IPeriodo crearPeriodoDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IPago crearPagoDAO(IGestorAccesoDatos gestorAccesoDatos);


    }
}
