using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Entidades
{
    public class Ingreso
    {
        private int id_ingreso;
        private float monto;
        private string razon;
        private Periodo periodo;

        public int Id_ingreso { get => id_ingreso; set => id_ingreso = value; }
        public string Razon { get => razon; set => razon = value; }
        public float Monto { get => monto; set => monto = value; }
        public Periodo Periodo { get => periodo; set => periodo = value; }
    }
}
