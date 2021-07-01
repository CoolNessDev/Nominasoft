﻿using System;
using System.Windows.Forms;

namespace NOMINASOFT
{
    public partial class Nominasoft : Form
    {
        public Nominasoft()
        {
            InitializeComponent();
        }

        private void btnGestionarContrato_Click(object sender, EventArgs e)
        {
            GestionarContrato gestionarContrato = new GestionarContrato();
            gestionarContrato.ShowDialog();
        }

        private void btnProcesarPagos_Click(object sender, EventArgs e)
        {
            ProcesarPago procesarPago = new ProcesarPago();
            procesarPago.ShowDialog();
        }
    }
}
