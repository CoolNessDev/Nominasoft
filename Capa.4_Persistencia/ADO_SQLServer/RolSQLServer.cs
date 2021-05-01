using Capa._3_Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._4_Persistencia.ADO_SQLServer
{
    public class RolSQLServer : IRol
    {
        private GestorSQLServer gestorSQL;
        public RolSQLServer(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQLServer)gestorSQL;
        }
    }
}
