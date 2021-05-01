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
        private float porsentaje_descuento;

        public int Id_afp { get => id_afp; set => id_afp = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Porsentaje_descuento { get => porsentaje_descuento; set => porsentaje_descuento = value; }
    }
}
