using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOMINASOFT_Consola
{
    public class Contratos
    {
        private int id_contrato;
        private bool asignacionFamiliar;
        private string cargo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int horasContratadasPorSemana;
        private int valorHora;
        private bool estado;

        private Afp afp;
        private Empleado empleado;
        private Pagos pago;

        public int Id_contrato { get => id_contrato; set => id_contrato = value; }
        public bool AsignacionFamiliar { get => asignacionFamiliar; set => asignacionFamiliar = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public int HorasContratadasPorSemana { get => horasContratadasPorSemana; set => horasContratadasPorSemana = value; }
        public int ValorHora { get => valorHora; set => valorHora = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Afp Afp { get => afp; set => afp = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Pagos Pago { get => pago; set => pago = value; }

        public double CalcularMontoPorAsignacionFamiliar(float sueldoMinimo)
        {
            if (AsignacionFamiliar)
            {
                return sueldoMinimo * 0.1;
            }
            return 0;
        }

 
        public bool ValidarFechaFinContrato()
        {
            if ((FechaFin - FechaInicio).TotalDays > 90 && (FechaFin - FechaInicio).TotalDays < 365)
            {
                return true;
            }
            return false;
        }


        public bool ValidarFechaInicioContrato(DateTime FechaFinAnterior)
        {
            if (FechaInicio > FechaFinAnterior)
            {
                return true;
            }
            return false;
        }
        /*
         El total de horas contratadas por semana sólo puede 
        ser de 8 a 40 horas, pero sólo valores enteros con 
        diferencia de 4 horas a partir de las 8 horas. Por 
        ejemplo: 8, 12, 16, … , 36, 40
         */
        public bool ValidarHoras()
        {
            if (8<HorasContratadasPorSemana && HorasContratadasPorSemana<40 && HorasContratadasPorSemana%4==0)
            {
                return true;
            }
            return false;
        }
        /*
         El valor hora de un contrato sólo puede ser desde 10 
        soles a 60 soles, pero sólo valores entero
         */
        public bool ValidarValorHoras()
        {
            if(10<ValorHora && ValorHora < 60 && ValorHora-(int)ValorHora==0)
            {
                return true;
            }
            return false;
        }
        /*
         Un contrato está vigente si su fecha fin es mayor o igual 
        a la fecha actual y no está anulado.
         */
        public bool ValidarVigenciaContrato()
        {
            DateTime currentDate = new DateTime();
            if(FechaFin>= currentDate && Estado)
            {
                return true;
            }
            return false;
        }
    }
}
