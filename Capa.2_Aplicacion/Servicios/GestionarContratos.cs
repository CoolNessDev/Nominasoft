using Capa._3_Dominio.Contratos;
using Capa._3_Dominio.Entidades;
using Capa._3_Dominio.Servicios;
using Capa._4_Persistencia.FabricaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._2_Aplicacion.Servicios
{
    public class GestionarContratos
    {
        private IGestorAccesoDatos gestorAccesoDatos;
        private IEmpleado empleadoDAO;
        private IAfp afpDAO;
        private IContrato contratoDAO;

        public GestionarContratos()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();
            empleadoDAO = fabricaAbstracta.crearEmpleadoDAO(gestorAccesoDatos);
            afpDAO = fabricaAbstracta.crearAfpDAO(gestorAccesoDatos);
            contratoDAO = fabricaAbstracta.crearContratoDAO(gestorAccesoDatos);
        }

        public Empleado BuscarEmpleado(int dni)
        {
            gestorAccesoDatos.AbrirConexion();
            Empleado empleado = empleadoDAO.BuscarEmpleadoPorDNI(dni);
            gestorAccesoDatos.CerrarConexion();
            return empleado;
        }

        public List<Afp> llenarComboBoxAFP()
        {
            gestorAccesoDatos.AbrirConexion();
            List<Afp> listarAfp = afpDAO.ListarAfps();
            gestorAccesoDatos.CerrarConexion();
            return listarAfp;
        }


        public Afp BuscarAFP(string AFP)
        {
            gestorAccesoDatos.AbrirConexion();
            Afp afp = afpDAO.BuscarDatosDelAfp_PorNombre(AFP);
            gestorAccesoDatos.CerrarConexion();
            return afp;
        }

        public Afp BuscarAFPCodigo(int codigo)
        {
            gestorAccesoDatos.AbrirConexion();
            Afp afp = afpDAO.BuscarDatosDelAfp_PorCodigo(codigo);
            gestorAccesoDatos.CerrarConexion();
            return afp;
        }

        public void GuardarContratos(Contrato contrato)
        {
            /*GestionarLosContratos gestionarLosContratos = new GestionarLosContratos();
            if (gestionarLosContratos.ValidarContrato(contrato) == true)
            {
                gestorAccesoDatos.AbrirConexion();
                contratoDAO.CrearContrato(contrato);
                gestorAccesoDatos.CerrarConexion();
            }*/
            gestorAccesoDatos.AbrirConexion();
            contratoDAO.CrearContrato(contrato);
            gestorAccesoDatos.CerrarConexion();
        }

        public Contrato MostrarContratos(int codigoEmpleado)
        {
            gestorAccesoDatos.AbrirConexion();
            Contrato contrato = contratoDAO.MostrarDatosContrato(codigoEmpleado);
            gestorAccesoDatos.CerrarConexion();
            return contrato;
        }
        public void EditarContratos(Contrato contrato,int codigoEmpleado)
        {
            /*GestionarLosContratos gestionarLosContratos = new GestionarLosContratos();

            if(gestionarLosContratos.ValidarContrato(contrato) == true)
            {
                gestorAccesoDatos.AbrirConexion();
                contratoDAO.EditarContrato(contrato, codigoEmpleado);
                gestorAccesoDatos.CerrarConexion();
            }*/
            gestorAccesoDatos.AbrirConexion();
            contratoDAO.EditarContrato(contrato, codigoEmpleado);
            gestorAccesoDatos.CerrarConexion();
        }

        public void AnularContratos(Contrato contrato, int codigoEmpleado)
        {
            gestorAccesoDatos.AbrirConexion();
            contratoDAO.AnularContrato(contrato, codigoEmpleado);
            gestorAccesoDatos.CerrarConexion();
        }
    }
}
