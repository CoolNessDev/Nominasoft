using Capa._3_Dominio.Entidades;
using System.Collections.Generic;

namespace Capa._3_Dominio.Contratos
{
    public interface IAfp
    {
        List<Afp> ListarAfps();
        Afp BuscarDatosDelAfp_PorNombre(string nombre);
        Afp BuscarDatosDelAfp_PorCodigo(int codigo);
    }
}
