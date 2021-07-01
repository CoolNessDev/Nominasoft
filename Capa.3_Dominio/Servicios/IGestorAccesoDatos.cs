namespace Capa._3_Dominio.Servicios
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
