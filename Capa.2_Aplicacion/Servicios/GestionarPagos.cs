

using Capa._3_Dominio.Entidades;
using Capa._3_Dominio.Pagos;
using Capa._3_Dominio.Servicios;
using Capa._4_Persistencia.FabricaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._2_Aplicacion.Servicios
{

    public class GestionarPagos
    {
        private IGestorAccesoDatos gestorAccesoDatos;
        private IPeriodo periodoDAO;
        public GestionarPagos()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();
            periodoDAO = fabricaAbstracta.crearPeriodoDAO(gestorAccesoDatos);
        }
        public Periodo GetPeriodoActivo()
        {
            gestorAccesoDatos.AbrirConexion();
            Periodo periodo = periodoDAO.GetPeriodoActivo();
            gestorAccesoDatos.CerrarConexion();
            return periodo;
        }
    }
}
