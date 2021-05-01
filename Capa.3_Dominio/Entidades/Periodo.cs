using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Periodo
    {
        private int id_periodo;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private float semanas;
        private float horas_extra;
        private float horas_ausente;
        private bool estado;
        private Contrato contrato;

        private Contrato Contrato { get => contrato; set => contrato = value; }
        public int Id_periodo { get => id_periodo; set => id_periodo = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public float Semanas { get => semanas; set => semanas = value; }
        public float Horas_extras { get => horas_extra; set => horas_extra = value; }
        public float Horas_ausentes { get => horas_ausente; set => horas_ausente = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
