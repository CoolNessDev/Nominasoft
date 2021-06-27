using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Afp
    {
        public int Id_afp { get; set; }
        public string Nombre { get; set; }
        public decimal Porsentaje_descuento { get; set; }
        public List<Contrato> Contratos { get; set; }
    }
}
