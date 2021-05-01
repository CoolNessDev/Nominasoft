using Capa._3_Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._4_Persistencia.ADO_MySQL
{
    public class IngresoMySQL : IIngreso
    {
        private GestorMySQL gestorSQL;
        public IngresoMySQL(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorMySQL)gestorSQL;
        }
    }
}
