using Capa._3_Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._4_Persistencia.ADO_MySQL
{
    public class DescuentoMySQL : IDescuento
    {
        private GestorMySQL gestorSQL;
        public DescuentoMySQL(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorMySQL)gestorSQL;
        }
    }
}
