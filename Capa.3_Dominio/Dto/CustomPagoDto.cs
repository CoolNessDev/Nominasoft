using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Dto
{
    public class CustomPagoDto
    {
        //FAltA FORMATEAR TABLA PARA QUE SALGAN EXACTAMENTE LOS SIGUIENTES DATOS DEL PAGO:
        //código del empleado, nombre del empleado, dni del empleado, el total de horas, el valor
        //hora, el sueldo básico, el total de ingresos, el total de descuento y el sueldo neto.

        private int id_empleado;
        private string nombreEmpleado;
        private string dniEmpleado;
        private decimal totalHoras;
        private decimal valorHora;
        private decimal sueldoMinimo;
        private decimal totalIngresos;
        private decimal totalDescuentos;
        private decimal sueldoNeto;



        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public string DniEmpleado { get => dniEmpleado; set => dniEmpleado = value; }
        public decimal TotalHoras { get => totalHoras; set => totalHoras = value; }
        public decimal ValorHora { get => valorHora; set => valorHora = value; }
        public decimal SueldoMinimo { get => sueldoMinimo; set => sueldoMinimo = value; }
        public decimal TotalIngresos { get => totalIngresos; set => totalIngresos = value; }
        public decimal TotalDescuentos { get => totalDescuentos; set => totalDescuentos = value; }
        public decimal SueldoNeto { get => sueldoNeto; set => sueldoNeto = value; }

    }
}
