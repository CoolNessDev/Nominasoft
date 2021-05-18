using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Contrato
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
        private Pago pago;

        public int Id_contrato { get => id_contrato; set => id_contrato = value; }
        public bool AsignacionFamiliar { get => asignacionFamiliar; set => asignacionFamiliar = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public int HorasContratadasPorSemana { get => horasContratadasPorSemana; set => horasContratadasPorSemana = value; }
        public int ValorHora { get => valorHora; set => valorHora = value; }
        public Afp Afp { get => afp; set => afp = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Pago Pago { get => pago; set => pago = value; }

        void CalcularMontoPorAsignacionFamiliar()
        {

        }

        void ValidarFechaFinContrato()
        {

        }

        void ValidarFechaInicioContrato()
        {

        }

        void ValidarHoras()
        {

        }

        void ValidarValorHoras()
        {

        }

        void ValidarVigenciaContrato()
        {

        }
    }
}
