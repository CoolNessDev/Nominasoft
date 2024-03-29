﻿using Capa._3_Dominio.Entidades;
using Capa._3_Dominio.Pagos;
using Capa._3_Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa._4_Persistencia.ADO_SQLServer
{
    class PeriodoSqlServer : IPeriodo
    {
        private readonly GestorSqlServer gestorSQL;
        public PeriodoSqlServer(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSqlServer)gestorSQL;
        }
        public bool InsertarContratoPeriodo(int idContrato, int idPeriodo)
        {
            string consulta = "insert into Contrato_periodo(ID_CONTRATO,ID_PERIODO) values (@ID_CONTRATO,@ID_PERIODO)";

            try
            {
                SqlCommand comando;

                comando = gestorSQL.ObtenerComandoSQL(consulta);
                comando.Parameters.AddWithValue("@ID_CONTRATO", idContrato);
                comando.Parameters.AddWithValue("@ID_PERIODO", idPeriodo);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrio un problema al intentar guardar,\n verifique si los datos ingresados son correctos." + er);
                return false;
            }

        }
        public Periodo GetPeriodoActivo()
        {
            List<Periodo> periodos = new List<Periodo>();

            Periodo periodo;
            string consultaSQL = "select * from Periodo where estado = 1 ORDER BY fechaFin";
            bool periodoObtenido = false;
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    periodo = ObtenerDatosPeriodo(resultadoSQL);
                    periodos.Add(periodo);
                    periodoObtenido = true;
                }
                if (!resultadoSQL.Read() && !periodoObtenido)
                {
                    return null;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error obtener periodo activo" + er);
                throw;
            }
            return periodos[0];
        }
        public bool UpdatePeriodo(Periodo periodo)
        {
            bool update = false;
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
                throw;
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
