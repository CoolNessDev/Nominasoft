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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionarContrato gestionarContrato = new GestionarContrato();
            gestionarContrato.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcesarPago procesarPago = new ProcesarPago();
            procesarPago.ShowDialog();
        }
    }
}
