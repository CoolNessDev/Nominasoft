using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Rol
    {
        private int id_rol;
        private string nombre;

        public int Id_rol { get => id_rol; set => id_rol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
