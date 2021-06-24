using Capa._3_Dominio.Contratos;
using Capa._3_Dominio.Entidades;
using Capa._3_Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._4_Persistencia.ADO_SQLServer
{
    public class GestorSQLServer : IGestorAccesoDatos
    {
        private SqlConnection conexion;
        private SqlTransaction transaccion;

        public void AbrirConexion()
        {
            try
            {
                conexion = new SqlConnection();
                //conexion.ConnectionString = "Data Source=(local);Initial Catalog=CALIDAD_G5 ;Integrated Security=true";//Rellenar con los datos de SQLServer
                conexion.ConnectionString = "Data Source=(local);Initial Catalog=nominasoft ;Integrated Security=true";//Rellenar con los datos de SQLServer
                conexion.Open();
            }
            catch (Exception err)
            {
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

        public SqlDataReader EjecutarConsulta(string sentenciaSQL)
        {
            try
            {
                SqlCommand comandoSQL = conexion.CreateCommand();
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

        public SqlCommand ObtenerComandoSQL(string sentenciaSQL)
        {
            try
            {
                SqlCommand comandoSQL = conexion.CreateCommand();
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

        public SqlCommand ObtenerComandoDeProcedimiento(string procedimientoAlmacenado)
        {
            try
            {
                SqlCommand comandoSQL = new SqlCommand(procedimientoAlmacenado, conexion);
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandType = CommandType.StoredProcedure;
                return comandoSQL;
            }
            catch (Exception err)
            {
                throw new Exception("Error de comando en la Base de Datos.", err);
            }
        }
        public Contrato ObtenerContrato(SqlDataReader resultadoSQL)
        {
            Contrato contrato = new Contrato();
            contrato.Id_contrato = resultadoSQL.GetInt32(0);
            contrato.AsignacionFamiliar = resultadoSQL.GetBoolean(1);
            contrato.Cargo = resultadoSQL.GetString(2);
            contrato.FechaInicio = resultadoSQL.GetDateTime(3);
            contrato.FechaFin = resultadoSQL.GetDateTime(4);
            contrato.HorasContratadasPorSemana = resultadoSQL.GetInt32(5);
            contrato.ValorHora = resultadoSQL.GetInt32(6);
            contrato.Estado = resultadoSQL.GetBoolean(7);
            Afp afp = new Afp();
            afp.Id_afp = resultadoSQL.GetInt32(8);
            contrato.Afp = afp;
            if (!contrato.ValidarVigenciaContrato())
            {
                contrato.Estado = false;
            }
            return contrato;

        }
    }
}
