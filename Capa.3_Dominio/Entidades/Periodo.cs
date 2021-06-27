using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Periodo
    {
        public int Id_periodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; }
        public List<Contrato> Contratos { get; set; }
        public ConceptoIngresoDeDescuento ConceptoIngresoDeDescuento { get; set; }
        public Pago Pago { get; set; }

        public int CalcularSemanasPeriodo()
        {
            TimeSpan diferenciaFechas = FechaFin - FechaInicio;
            int dias = diferenciaFechas.Days;
            return dias / 7;
        }

        /// <summary>
        /// Para poder procesar un periodo de pago activo, la fecha 
        /// actual debe ser mayor o igual a la fecha fin del periodo
        /// de pago
        /// </summary>
        /// <returns></returns>
        public bool ValidarPeriodoActivos()
        {
            DateTime now = DateTime.Now;
            if (now>=FechaFin)
            {
                return true;
            }
            return false;
        }
    }
}
