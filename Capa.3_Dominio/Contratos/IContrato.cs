using Capa._3_Dominio.Entidades;
using System.Collections.Generic;

namespace Capa._3_Dominio.Contratos
{
    public interface IContrato
    {
        void CrearContrato(Contrato contrato);
        void EditarContrato(Contrato contrato, int codigoEmpleado);
        void AnularContrato(Contrato contrato, int codigoEmpleado);
        Contrato GetContrato(int id);
        Contrato MostrarDatosContrato(int CodigoEmpleado);
        List<Contrato> GetContratosByPeriodo(Periodo periodo);
        //Mover a ICID
        ConceptoIngresoDeDescuento GetCIDByContrato_Periodo(int idContrato, int idPeriodo);
    }
}
