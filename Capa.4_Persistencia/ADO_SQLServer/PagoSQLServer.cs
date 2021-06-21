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
using System.Windows.Forms;

namespace Capa._4_Persistencia.ADO_SQLServer
{
    class PagoSQLServer : IPago
    {
        private GestorSQLServer gestorSQL;
        public PagoSQLServer(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQLServer)gestorSQL;
        }
        public bool registerPago(Pago pago)
        {
            bool insert = false;
            SqlCommand cmd = null;
            try
            {
                cmd = gestorSQL.ObtenerComandoDeProcedimiento("InsertarPago");
                cmd.Parameters.AddWithValue("@fechaActual", pago.FechaActual);
                cmd.Parameters.AddWithValue("@montoAsignacionAFP", pago.MontoAsignacionFamiliar);
                cmd.Parameters.AddWithValue("@descuentoAFP", pago.DescuentAFP);
                cmd.Parameters.AddWithValue("@sueldoMinimo", pago.SueldoMinimo);
                cmd.Parameters.AddWithValue("@porsentajeDescuento", pago.PorcentajeDescuento);
                cmd.Parameters.AddWithValue("@valorHora", pago.ValorHora);
                cmd.Parameters.AddWithValue("@totalHora", pago.TotalHoras);
                cmd.Parameters.AddWithValue("@ID_PERIODO", pago.Periodo.Id_periodo);
                cmd.Parameters.AddWithValue("@ID_CONTRATO", pago.Contrato.Id_contrato);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    insert = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error update Periodo " + e);
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return insert;
        }
        public List<Pago> GetPagosByPeriodo(Periodo periodo)
        {
            List<Pago> pagos=new List<Pago>();
            Pago pago;
            string consulta = "SELECT * from Pago where ID_PERIODO = " + periodo.Id_periodo;

            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consulta);
                while (resultadoSQL.Read())
                {
                    pago = ObtenerPago(resultadoSQL);
                    pagos.Add(pago);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No existen Pagos." + err);
                return null;
            }
            return pagos;
        }
        private Pago ObtenerPago(SqlDataReader resultadoSQL)
        {
            Pago pago = new Pago();
            pago.Id_pago = resultadoSQL.GetInt32(0);
            pago.FechaActual = resultadoSQL.GetDateTime(1);
            pago.MontoAsignacionFamiliar = resultadoSQL.GetDecimal(2);
            pago.DescuentAFP = resultadoSQL.GetDecimal(3);
            pago.SueldoMinimo = resultadoSQL.GetDecimal(4);
            pago.PorcentajeDescuento = resultadoSQL.GetDecimal(5);
            pago.ValorHora = resultadoSQL.GetDecimal(6);
            pago.TotalHoras = resultadoSQL.GetDecimal(7);
            Periodo periodo = new Periodo();
            Contrato contrato = new Contrato();
            periodo.Id_periodo = resultadoSQL.GetInt32(8);
            contrato.Id_contrato = resultadoSQL.GetInt32(9);

            pago.Periodo = periodo;
            pago.Contrato = contrato;

            return pago;

        }
    }
   
}
