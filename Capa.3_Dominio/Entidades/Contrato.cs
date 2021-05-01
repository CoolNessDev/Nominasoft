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
        private bool asignacion_familiar;
        private bool estado;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private int horas_semana;
        private int valor_hora;
        private float monto_horas_extras;
        private float monto_reingresos;
        private float monto_horas_ausentes;
        private Empleado empleado;
        private Afp afp;

        public int Id_contrato { get => id_contrato; set => id_contrato = value; }
        public bool Asignacion_familiar { get => asignacion_familiar; set => asignacion_familiar = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public int Horas_semana { get => horas_semana; set => horas_semana = value; }
        public int Valor_hora { get => valor_hora; set => valor_hora = value; }
        public float Monto_horas_extras { get => monto_horas_extras; set => monto_horas_extras = value; }
        public float Monto_reingreso { get => monto_reingresos; set => monto_reingresos = value; }
        public float Monto_horas_ausentes { get => monto_horas_ausentes; set => monto_horas_ausentes = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Afp Afp { get => afp; set => afp = value; }

    }
}
