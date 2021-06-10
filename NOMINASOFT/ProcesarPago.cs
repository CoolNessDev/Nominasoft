using Capa._2_Aplicacion.Servicios;
using Capa._3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOMINASOFT
{
    public partial class ProcesarPago : Form
    {
        GestionarPagos servicio;
        public ProcesarPago()
        {
            InitializeComponent();
            servicio = new GestionarPagos();
            Periodo periodo = servicio.GetPeriodoActivo();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
