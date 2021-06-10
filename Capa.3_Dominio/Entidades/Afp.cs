using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Afp
    {
        private int id_afp;
        private string nombre;
        private double porsentaje_descuento;
        private List<Contrato> contratos;

        public int Id_afp { get => id_afp; set => id_afp = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Porsentaje_descuento { get => porsentaje_descuento; set => porsentaje_descuento = value; }
        public List<Contrato> Contratos { get => contratos; set => contratos = value; }
    }
}
