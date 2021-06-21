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
    public class ContratoSQLServer : IContrato
    {
        private GestorSQLServer gestorSQL;
        public ContratoSQLServer(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQLServer)gestorSQL;
        }

        public void CrearContrato(Contrato contrato)
        {
            string crearContrato = "insert into Contrato(asignacionFamiliar, cargo, fechaInicial, fechaFinal, horasContradasPorSemana, valorHora, estado, ID_AFP, ID_EMPLEADO) " +
                    "values(@asignacionFamiliar ,@cargo ,@fechaInicial ,@fechaFinal ,@horasContradasPorSemana,@valorHora ,@estado ,@ID_AFP ,@ID_EMPLEADO )";

            try
            {
                SqlCommand comando;

                comando = gestorSQL.ObtenerComandoSQL(crearContrato);
                comando.Parameters.AddWithValue("@asignacionFamiliar", contrato.AsignacionFamiliar);
                comando.Parameters.AddWithValue("@cargo", contrato.Cargo);
                comando.Parameters.AddWithValue("@fechaInicial", contrato.FechaInicio.Date);
                comando.Parameters.AddWithValue("@fechaFinal", contrato.FechaFin.Date);
                comando.Parameters.AddWithValue("@horasContradasPorSemana", contrato.HorasContratadasPorSemana);
                comando.Parameters.AddWithValue("@valorHora", contrato.ValorHora);
                comando.Parameters.AddWithValue("@estado", contrato.Estado);
                comando.Parameters.AddWithValue("@ID_AFP", contrato.Afp.Id_afp);
                comando.Parameters.AddWithValue("@ID_EMPLEADO", contrato.Empleado.Id_empleado);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se guardó el nuevo contrato");
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrio un problema al intentar guardar,\n verifique si los datos ingresados son correctos." + er);
            }

        }

        public void EditarContrato(Contrato contrato, int codigoEmpleado)
        {
            bool edit = false;

            try
            {
                SqlCommand cmd;

                cmd = gestorSQL.ObtenerComandoDeProcedimiento("ActualizarContrato");
                cmd.Parameters.AddWithValue("@idContrato", contrato.Id_contrato);
                cmd.Parameters.AddWithValue("@asignacionFamiliar", contrato.AsignacionFamiliar);
                cmd.Parameters.AddWithValue("@cargo", contrato.Cargo);
                cmd.Parameters.AddWithValue("@fechaInicial", contrato.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaFinal", contrato.FechaFin);
                cmd.Parameters.AddWithValue("@horasContradasPorSemana", contrato.HorasContratadasPorSemana);
                cmd.Parameters.AddWithValue("@valorHora", contrato.ValorHora);
                cmd.Parameters.AddWithValue("@estado", contrato.Estado);
                cmd.Parameters.AddWithValue("@ID_AFP", contrato.Afp.Id_afp);
                cmd.Parameters.AddWithValue("@ID_EMPLEADO", contrato.Empleado.Id_empleado);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edit = true;
                }
                MessageBox.Show("Se guardó las modificaciones del contrato");
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrio un problema al intentar Editar,\n verifique si los datos ingresados son correctos." + er);
            }
        }

        public void AnularContrato(Contrato contrato, int codigoEmpleado)
        {
            string anularContrato = "update Contrato Set estado = @estado where ID_EMPLEADO = " + codigoEmpleado + "" +
                                     "and fechaInicial = (Select MAX(fechaInicial) from Contrato where ID_EMPLEADO = " + codigoEmpleado + ")" +
                                     "and estado = 1";

            try
            {
                SqlCommand comando;

                comando = gestorSQL.ObtenerComandoSQL(anularContrato);
                comando.Parameters.AddWithValue("@estado", contrato.Estado);

                comando.ExecuteNonQuery();
                MessageBox.Show("Se anuló el contrato");
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrio un problema al intentar Anular,\n verifique si los datos ingresados son correctos." + er);
            }
        }

        public Contrato MostrarDatosContrato(int CodigoEmpleado)
        {
            Contrato contrato;
            string mostrarContrato = "select idContrato, asignacionFamiliar, cargo, fechaInicial, fechaFinal, horasContradasPorSemana, valorHora, estado, ID_AFP, ID_EMPLEADO from Contrato where ID_EMPLEADO = " + CodigoEmpleado + "" +
                                     "and fechaInicial = (Select MAX(fechaInicial) from Contrato where ID_EMPLEADO = " + CodigoEmpleado + ")" +
                                     "and estado = 1 ORDER BY fechaFinal desc";

            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(mostrarContrato);
                if (resultadoSQL.Read())
                {
                    contrato = ObtenerContrato(resultadoSQL);
                }
                else
                {
                    MessageBox.Show("No existe un Contrato activo.");
                    return null;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No existe el Contrato." + err);
                return null;
            }
            return contrato;
        }

        public List<Contrato> GetContratosByPeriodo(Periodo periodo)
        {
            List<Contrato> contratos = new List<Contrato>();
            Contrato contrato;
            SqlCommand cmd = null;
            try
            {
                cmd = gestorSQL.ObtenerComandoDeProcedimiento("ListarContratosProcesar");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PERIODO", periodo.Id_periodo);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contrato = ObtenerContrato(dr);
                    contrato.Periodo = periodo;
                    if (contrato.ValidarContratoProcesar())
                    {
                        contratos.Add(contrato);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error update Periodo " + e);
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return contratos;
        }


        private Contrato ObtenerContrato(SqlDataReader resultadoSQL)
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
            Afp afp = new Afp
            {
                Id_afp = resultadoSQL.GetInt32(8)
            };
            contrato.Afp = afp;
            Empleado empleado = new Empleado
            {
                Id_empleado = resultadoSQL.GetInt32(9)
            };
            contrato.Empleado = empleado;
            if (!contrato.ValidarVigenciaContrato()) 
            {
                contrato.Estado = false;
            }
            return contrato;

        }
    }
}
