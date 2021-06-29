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
    public class EmpleadoSqlServer : IEmpleado
    {
        private readonly GestorSqlServer gestorSQL;
        public EmpleadoSqlServer(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSqlServer)gestorSQL;
        }

        public Empleado BuscarEmpleadoPorDNI(string DNI)
        {
            Empleado empleado=null;
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
            catch (Exception e)
            {
                MessageBox.Show("Error al buscar el empleadon por DNI: " + e);
                throw;
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
                    contrato = gestorSQL.ObtenerContrato(resultadoSQL2);
                    contratos.Add(contrato);
                }
                resultadoSQL2.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener contratos: "+er);
            }
            return contratos;
        }
        public Empleado BuscarEmpleado(int id)
        {
            Empleado empleado=null;
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
            catch (Exception er)
            {
                MessageBox.Show("Error al buscar el empleado: " + er);
                throw;
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
        
    }
}
