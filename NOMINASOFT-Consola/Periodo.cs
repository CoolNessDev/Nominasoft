﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOMINASOFT_Consola
{
    public class Periodo
    {
        private int id_periodo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private bool estado;

        public int Id_periodo { get => id_periodo; set => id_periodo = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public bool Estado { get => estado; set => estado = value; }

        public double ValidarPeriodoActivos()
        {
            throw new NotImplementedException();
        }
        public double CalcularSemanasPeriodos()
        {
            throw new NotImplementedException();
        }
    }
}
