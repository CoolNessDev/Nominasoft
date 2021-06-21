using Capa._3_Dominio.Contratos;
using Capa._3_Dominio.Entidades;
using Capa._3_Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa._4_Persistencia.ADO_SQLServer
{
    public class EmpleadoSQLServer : IEmpleado
    {
        private GestorSQLServer gestorSQL;
        public EmpleadoSQLServer(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQLServer)gestorSQL;
        }

        public Empleado BuscarEmpleadoPorDNI(string DNI)
        {
            Empleado empleado;
            string consultaSQL = "select * from Empleado where dni = '" + DNI + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    empleado = ObtenerDatosEmpleaods(resultadoSQL);
                }
                else
                {
                    return null;
                }
                resultadoSQL.Close();
            }
            catch (Exception err)
            {
                throw err;
            }
            return empleado;
        }
        public List<Contrato> obtenerContratos(int idEmpleado)
        {
            List<Contrato> contratos = new List<Contrato>();
            Contrato contrato;
            string consultaSQL = "select* from Contrato where ID_EMPLEADO ='" + idEmpleado + "' Order by fechaFinal desc";
            try
            {
                SqlDataReader resultadoSQL2 = gestorSQL.EjecutarConsulta(consultaSQL);
                while (resultadoSQL2.Read())
                {
                    contrato = ObtenerContrato(resultadoSQL2);
                    contratos.Add(contrato);
                }
                resultadoSQL2.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: "+er);
            }
            return contratos;
        }
        public Empleado BuscarEmpleado(int id)
        {
            Empleado empleado;
            string consultaSQL = "select * from Empleado where idEmpleado = '" + id + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    empleado = ObtenerDatosEmpleaods(resultadoSQL);
                }
                else
                {
                    return null;
                }
                resultadoSQL.Close();
            }
            catch (Exception err)
            {
                throw err;
            }
            return empleado;
        }
        private Empleado ObtenerDatosEmpleaods(SqlDataReader resultadoSQL)
        {
            Empleado empleado = new Empleado();
            empleado.Id_empleado = resultadoSQL.GetInt32(0);
            empleado.Dni = resultadoSQL.GetString(1);
            empleado.Direccion = resultadoSQL.GetString(2);
            empleado.EstadoCivil = resultadoSQL.GetString(3);
            empleado.FechaNacimiento = resultadoSQL.GetDateTime(4);
            empleado.GradoAcademico = resultadoSQL.GetString(5);
            empleado.Telefono = resultadoSQL.GetString(6);
            empleado.Nombre = resultadoSQL.GetString(7);
            return empleado;
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
