using Capa._3_Dominio.Contratos;
using Capa._3_Dominio.Entidades;
using Capa._3_Dominio.Pagos;
using Capa._3_Dominio.Servicios;
using Capa._4_Persistencia.FabricaDatos;
using System.Collections.Generic;

namespace Capa._2_Aplicacion.Servicios
{
    public class GestionarContratos
    {
        private readonly IGestorAccesoDatos gestorAccesoDatos;
        private readonly IEmpleado empleadoDAO;
        private readonly IAfp afpDAO;
        private readonly IContrato contratoDAO;
        private readonly IPeriodo periodoDAO;

        public GestionarContratos()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();
            empleadoDAO = fabricaAbstracta.crearEmpleadoDAO(gestorAccesoDatos);
            afpDAO = fabricaAbstracta.crearAfpDAO(gestorAccesoDatos);
            contratoDAO = fabricaAbstracta.crearContratoDAO(gestorAccesoDatos);
            periodoDAO = fabricaAbstracta.crearPeriodoDAO(gestorAccesoDatos);
        }
        public Periodo GetPeriodoActivo()
        {
            gestorAccesoDatos.AbrirConexion();
            Periodo periodo = periodoDAO.GetPeriodoActivo();
            gestorAccesoDatos.CerrarConexion();
            return periodo;
        }
        public bool InsertarContratoPeriodo(int idContrato, int idPeriodo)
        {
            gestorAccesoDatos.AbrirConexion();
            bool insert = periodoDAO.InsertarContratoPeriodo(idContrato, idPeriodo);
            gestorAccesoDatos.CerrarConexion();
            return insert;
        }

        public Empleado BuscarEmpleado(string dni)
        {
            gestorAccesoDatos.AbrirConexion();
            Empleado empleado = empleadoDAO.BuscarEmpleadoPorDNI(dni);
            if (empleado != null)
            {
                empleado.Contratos = empleadoDAO.obtenerContratos(empleado.Id_empleado);
            }
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
        public void EditarContratos(Contrato contrato, int codigoEmpleado)
        {
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
