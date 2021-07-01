using Capa._3_Dominio.Entidades;
using System.Collections.Generic;

namespace Capa._3_Dominio.Contratos
{
    public interface IPago
    {
        bool registerPago(Pago pago);
        List<Pago> GetPagosByPeriodo(Periodo periodo);
    }
}
