using System;
using System.Collections.Generic;

namespace Capa._3_Dominio.Entidades
{
    public class Empleado
    {
        public int Id_empleado { get; set; }
        public string Dni { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string GradoAcademico { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public List<Contrato> Contratos { get; set; }

    }
}
