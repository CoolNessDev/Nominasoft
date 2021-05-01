using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Empleado
    {

        private int id_empleado;
        private string dni;
        private string estado_civil;
        private DateTime fecha_nacimiento;
        private string grado_academico;
        private string nombre;
        private string telefono;
        private string direccion;
        private Rol rol_empleado;

        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Estado_civil { get => estado_civil; set => estado_civil= value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Grado_academico { get => grado_academico; set => grado_academico = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public Rol Rol_empleado { get => rol_empleado; set => rol_empleado = value; }

    }
}
