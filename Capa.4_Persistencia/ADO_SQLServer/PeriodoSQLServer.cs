using Capa._3_Dominio.Pagos;
using Capa._3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa._3_Dominio.Servicios;

namespace Capa._4_Persistencia.ADO_SQLServer
{
    class PeriodoSQLServer : IPeriodo
    {
        private GestorSQLServer gestorSQL;
        public PeriodoSQLServer(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQLServer)gestorSQL;
        }
        public Periodo GetPeriodoActivo()
        {
            List<Periodo> periodos = new List<Periodo>();

            Periodo periodo;
            string consultaSQL = "select * from Periodo where estado = 1 ORDER BY fechaFin DESC";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    periodo = ObtenerDatosPeriodo(resultadoSQL);
                    periodos.Add(periodo);

                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return periodos[0];
        }
        public bool UpdatePeriodo(Periodo periodo)
        {
            bool update=false;
            SqlCommand cmd = null;
            try
            {
                cmd = gestorSQL.ObtenerComandoDeProcedimiento("ActualizarPeriodo");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPeriodo", periodo.Id_periodo);
                cmd.Parameters.AddWithValue("@fechaInicio", periodo.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", periodo.FechaFin);
                cmd.Parameters.AddWithValue("@estado", periodo.Estado);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    update = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error update Periodo " + e);
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return update;
        }
        private Periodo ObtenerDatosPeriodo(SqlDataReader resultadoSQL)
        {
            Periodo periodo = new Periodo();
            periodo.Id_periodo = resultadoSQL.GetInt32(0);
            periodo.FechaInicio = resultadoSQL.GetDateTime(1);
            periodo.FechaFin = resultadoSQL.GetDateTime(2);
            periodo.Estado = resultadoSQL.GetBoolean(3);

            return periodo;
        }
    }
}
