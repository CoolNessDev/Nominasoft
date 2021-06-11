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
    }
}
