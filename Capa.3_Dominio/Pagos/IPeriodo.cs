using Capa._3_Dominio.Entidades;

namespace Capa._3_Dominio.Pagos
{
    public interface IPeriodo
    {
        Periodo GetPeriodoActivo();
        bool UpdatePeriodo(Periodo periodo);
        bool InsertarContratoPeriodo(int idContrato, int idPeriodo);
    }
}
