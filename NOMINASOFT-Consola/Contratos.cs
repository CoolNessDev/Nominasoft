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
        public Afp Afp { get => afp; set => afp = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Pagos Pago { get => pago; set => pago = value; }

        public double CalcularMontoPorAsignacionFamiliar()
        {
            throw new NotImplementedException();
        }

 
        public double ValidarFechaFinContrato()
        {
            throw new NotImplementedException();
        }


        public double ValidarFechaInicioContrato()
        {
            throw new NotImplementedException();
        }

        public double ValidarHoras()
        {
            throw new NotImplementedException();
        }

        public double ValidarValorHoras()
        {
            throw new NotImplementedException();
        }

        public double ValidarVigenciaContrato()
        {
            throw new NotImplementedException();
        }
    }
}
