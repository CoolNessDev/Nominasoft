using Capa._3_Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._4_Persistencia.ADO_MySQL
{
    public class ContratoMySQL : IContrato
    {
        private GestorMySQL gestorSQL;
        public ContratoMySQL(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorMySQL)gestorSQL;
        }
    }
}
