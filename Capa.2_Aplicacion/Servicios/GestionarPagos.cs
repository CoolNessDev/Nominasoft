﻿

using Capa._3_Dominio.Contratos;
using Capa._3_Dominio.Entidades;
using Capa._3_Dominio.Pagos;
using Capa._3_Dominio.Servicios;
using Capa._4_Persistencia.FabricaDatos;
using System.Collections.Generic;

namespace Capa._2_Aplicacion.Servicios
{

    public class GestionarPagos
    {
        private readonly IGestorAccesoDatos gestorAccesoDatos;
        private readonly IPeriodo periodoDAO;
        private readonly IContrato contratoDAO;
        private readonly IPago pagoDAO;
        private readonly IEmpleado empleadoDAO;

        public GestionarPagos()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();
            periodoDAO = fabricaAbstracta.crearPeriodoDAO(gestorAccesoDatos);
            contratoDAO = fabricaAbstracta.crearContratoDAO(gestorAccesoDatos);
            pagoDAO = fabricaAbstracta.crearPagoDAO(gestorAccesoDatos);
            empleadoDAO = fabricaAbstracta.crearEmpleadoDAO(gestorAccesoDatos);
        }
        public Periodo GetPeriodoActivo()
        {
            gestorAccesoDatos.AbrirConexion();
            Periodo periodo = periodoDAO.GetPeriodoActivo();
            gestorAccesoDatos.CerrarConexion();
            return periodo;
        }
        public bool updatePeriodo(Periodo periodo)
        {
            gestorAccesoDatos.AbrirConexion();
            bool update = periodoDAO.UpdatePeriodo(periodo);
            gestorAccesoDatos.CerrarConexion();
            return update;
        }
        public List<Contrato> GetContratosByPeriodo(Periodo periodo)
        {
            gestorAccesoDatos.AbrirConexion();
            List<Contrato> contratos = contratoDAO.GetContratosByPeriodo(periodo);
            gestorAccesoDatos.CerrarConexion();
            return contratos;
        }
        public bool registerPago(Pago pago)
        {
            gestorAccesoDatos.AbrirConexion();
            bool registrar = pagoDAO.registerPago(pago);
            gestorAccesoDatos.CerrarConexion();
            return registrar;
        }
        public List<Pago> GetPagpsByPeriodo(Periodo periodo)
        {
            gestorAccesoDatos.AbrirConexion();
            List<Pago> pagos = pagoDAO.GetPagosByPeriodo(periodo);
            gestorAccesoDatos.CerrarConexion();
            return pagos;
        }
        public Contrato GetContrato(int id)
        {
            gestorAccesoDatos.AbrirConexion();
            Contrato contrato = contratoDAO.GetContrato(id);
            gestorAccesoDatos.CerrarConexion();
            return contrato;
        }
        public Empleado BuscarEmpleado(int id)
        {
            gestorAccesoDatos.AbrirConexion();
            Empleado empleado = empleadoDAO.BuscarEmpleado(id);
            gestorAccesoDatos.CerrarConexion();
            return empleado;
        }
        public ConceptoIngresoDeDescuento GetCIDByContrato_Periodo(int idContrato, int idPeriodo)
        {
            gestorAccesoDatos.AbrirConexion();
            ConceptoIngresoDeDescuento cid = contratoDAO.GetCIDByContrato_Periodo(idContrato, idPeriodo);
            gestorAccesoDatos.CerrarConexion();
            return cid;
        }
    }
}
