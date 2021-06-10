﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Periodo
    {
        private int id_periodo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private bool estado;
        private List<Contrato> contratos;
        private ConceptoIngresoDeDescuento conceptoIngresoDeDescuento;
        private Pago pago;

        public int Id_periodo { get => id_periodo; set => id_periodo = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public bool Estado { get => estado; set => estado = value; }
        public List<Contrato> Contratos  { get => contratos; set => contratos = value; }
        public ConceptoIngresoDeDescuento ConceptoIngresoDeDescuento { get => conceptoIngresoDeDescuento; set => conceptoIngresoDeDescuento = value; }
        public Pago Pago { get => pago; set => pago = value; }

        public int CalcularSemanasPeriodo()
        {
            TimeSpan diferenciaFechas = FechaFin - FechaInicio;
            int dias = diferenciaFechas.Days;
            return dias / 7;
        }

        public bool ValidarPeriodoActivos()
        {
            if (FechaFin > FechaInicio && Estado)
            {
                return true;
            }
            return false;
        }
    }
}
