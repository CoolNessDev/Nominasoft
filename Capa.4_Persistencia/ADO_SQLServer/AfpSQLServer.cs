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
    public class AfpSQLServer : IAfp
    {
        private readonly GestorSQLServer gestorSQL;

        public AfpSQLServer(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQLServer)gestorSQL;
        }

        public List<Afp> ListarAfps()
        {
            List<Afp> listaAfp = new List<Afp>();
            Afp afp;
            string consultaSQL = "select * from AFP";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    afp = ObtenerDatosAfp(resultadoSQL);
                    listaAfp.Add(afp);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return listaAfp;
        }


        public Afp BuscarDatosDelAfp_PorNombre(string nombre)
        {
            Afp afp=null;
            string consultaSQL = "select * from AFP where nombre = '" + nombre + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    afp = ObtenerDatosAfp(resultadoSQL);
                }
                else
                {
                    MessageBox.Show("No existe el AFP.");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return afp;
        }

        public Afp BuscarDatosDelAfp_PorCodigo(int codigo)
        {
            Afp afp=null;
            string consultaSQL = "select * from AFP where idAfp = '" + codigo + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    afp = ObtenerDatosAfp(resultadoSQL);
                }
                else
                {
                    MessageBox.Show("No existe el AFP.");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return afp;
        }
        private Afp ObtenerDatosAfp(SqlDataReader resultadoSQL)
        {
            Afp afp = new Afp();
            afp.Id_afp = resultadoSQL.GetInt32(0);
            afp.Nombre = resultadoSQL.GetString(1);
            afp.Porsentaje_descuento = resultadoSQL.GetDecimal(2);

            return afp;
        }
    }
}
