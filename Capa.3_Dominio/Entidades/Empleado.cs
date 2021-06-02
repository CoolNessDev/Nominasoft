﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Empleado
    {
        private int id_empleado;
        private int dni;
        private string estadoCivil;
        private DateTime fechaNacimiento;
        private string gradoAcademico;
        private string nombre;
        private int telefono;
        private string direccion;

        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Dni { get => dni; set => dni = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string GradoAcademico { get => gradoAcademico; set => gradoAcademico = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }


        

    }
}
