using Capa._3_Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._4_Persistencia.ADO_MySQL
{
    public class AfpMySQL : IAfp
    {
        private GestorMySQL gestorSQL;

        public AfpMySQL(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorMySQL)gestorSQL;
        }
    }
}
