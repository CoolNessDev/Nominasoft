using Capa._3_Dominio.Contratos;
using Capa._3_Dominio.Entidades;
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

        public Empleado BuscarEmpleadoPorDNI(int DNI)
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
            empleado.Dni = resultadoSQL.GetInt32(1);
            empleado.Direccion = resultadoSQL.GetString(2);
            empleado.EstadoCivil = resultadoSQL.GetString(3);
            empleado.FechaNacimiento = resultadoSQL.GetDateTime(4);
            empleado.GradoAcademico = resultadoSQL.GetString(5);
            empleado.Telefono = resultadoSQL.GetInt32(6);
            empleado.Nombre = resultadoSQL.GetString(7);
            return empleado;
        }
    }
}
