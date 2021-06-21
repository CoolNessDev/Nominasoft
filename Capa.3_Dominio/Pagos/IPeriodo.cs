using Capa._3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Pagos
{
    public interface IPeriodo
    {
        Periodo GetPeriodoActivo();
        bool UpdatePeriodo(Periodo periodo);
        bool InsertarContratoPeriodo(int idContrato, int idPeriodo);
    }
}
