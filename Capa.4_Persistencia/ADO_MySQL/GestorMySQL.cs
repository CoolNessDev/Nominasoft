using Capa._3_Dominio.Contratos;
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Capa._4_Persistencia.ADO_MySQL
{
    public class GestorMySQL : IGestorAccesoDatos
    {
        private MySqlConnection conexion;
        private MySqlTransaction transaccion;

        public void AbrirConexion()
        {
            try
            {
                conexion = new MySqlConnection();
                conexion.ConnectionString = "Server=us-cdbr-east-03.cleardb.com;Database=heroku_2ba31acba78a0d7 ; Uid=b3d1f76cb67209; Pwd=562721ea;";
                conexion.Open();
                Console.WriteLine("Connecion: ", conexion);
                Console.WriteLine(conexion);
            }
            catch (Exception err)
            {
                Console.WriteLine("ErrorConnecion : ", err);
                throw new Exception("Error en la conexión con la Base de Datos.", err);
            }

        }

        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Error al cerrar la conexión con la Base de Datos.", err);
            }

        }

        public void IniciarTransaccion()
        {
            try
            {
                AbrirConexion();
                transaccion = conexion.BeginTransaction();
            }
            catch (Exception err)
            {
                throw new Exception("Error al iniciar la transacción con la Base de Datos.", err);
            }
        }

        public void TerminarTransaccion()
        {
            try
            {
                transaccion.Commit();
                conexion.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Error al terminar la transacción con la Base de Datos.", err);
            }
        }

        public void CancelarTransaccion()
        {
            try
            {
                transaccion.Rollback();
                conexion.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Error al cancelar la transacción con la Base de Datos.", err);
            }
        }

        public MySqlDataReader EjecutarConsulta(string sentenciaSQL)
        {
            try
            {
                MySqlCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = sentenciaSQL;
                comandoSQL.CommandType = CommandType.Text;
                return comandoSQL.ExecuteReader();
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar consulta en la Base de Datos.", err);
            }
        }

        public MySqlCommand ObtenerComandoSQL(string sentenciaSQL)
        {
            try
            {
                MySqlCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = sentenciaSQL;
                comandoSQL.CommandType = CommandType.Text;
                return comandoSQL;
            }
            catch (Exception err)
            {
                throw new Exception("Error de comando en la Base de Datos.", err);
            }
        }

        public MySqlCommand ObtenerComandoDeProcedimiento(string procedimientoAlmacenado)
        {
            try
            {
                MySqlCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = procedimientoAlmacenado;
                comandoSQL.CommandType = CommandType.StoredProcedure;
                return comandoSQL;
            }
            catch (Exception err)
            {
                throw new Exception("Error de comando en la Base de Datos.", err);
            }
        }
    }
}
