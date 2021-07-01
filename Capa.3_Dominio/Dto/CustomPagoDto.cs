namespace Capa._3_Dominio.Dto
{
    public class CustomPagoDto
    {
        //FAltA FORMATEAR TABLA PARA QUE SALGAN EXACTAMENTE LOS SIGUIENTES DATOS DEL PAGO:
        //código del empleado, nombre del empleado, dni del empleado, el total de horas, el valor
        //hora, el sueldo básico, el total de ingresos, el total de descuento y el sueldo neto.

        public int Id_empleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string DniEmpleado { get; set; }
        public decimal TotalHoras { get; set; }
        public decimal ValorHora { get; set; }
        public decimal SueldoMinimo { get; set; }
        public decimal TotalIngresos { get; set; }
        public decimal TotalDescuentos { get; set; }
        public decimal SueldoNeto { get; set; }

    }
}
