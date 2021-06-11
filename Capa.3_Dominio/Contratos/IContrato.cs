using Capa._3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Contratos
{
    public interface IContrato
    {
        void CrearContrato(Contrato contrato);
        void EditarContrato(Contrato contrato, int codigoEmpleado);
        void AnularContrato(Contrato contrato, int codigoEmpleado);
        Contrato MostrarDatosContrato(int CodigoEmpleado);
        List<Contrato> GetContratosByPeriodo(Periodo periodo);
    }
}
