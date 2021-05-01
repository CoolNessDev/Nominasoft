using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Contratos
{
    public interface IGestorAccesoDatos
    {
        void AbrirConexion();
        void CerrarConexion();
        void IniciarTransaccion();
        void TerminarTransaccion();
        void CancelarTransaccion();
    }
}
