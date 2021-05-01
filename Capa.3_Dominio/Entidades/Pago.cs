using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Pago
    {
        private int id_pago;
        private DateTime fecha;
        private float monto_asignacion_familiar;
        private float descuento_afp;
        private float sueldo_neto;
        private float total_descuento;
        private float total_ingreso;
        private float total_horas;
        private Contrato contrato;

        public int Id_pago { get => id_pago; set => id_pago = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Monto_asignacion_familiar { get => monto_asignacion_familiar; set => monto_asignacion_familiar = value; }
        public float Descuento_afp { get => descuento_afp; set => descuento_afp = value; }
        public float Sueldo_neto { get => sueldo_neto; set => sueldo_neto = value; }
        public float Total_descuento { get => total_descuento; set => total_descuento = value; }
        public float Total_ingreso { get => total_ingreso; set => total_ingreso = value; }
        public float Total_horas { get => total_horas; set => total_horas = value; }
        public Contrato Contrato { get => contrato; set => contrato = value; }

    }
}
