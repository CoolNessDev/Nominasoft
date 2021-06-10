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
        Periodo periodo;
        public ProcesarPago()
        {
            InitializeComponent();
            disableInputs();
            servicio = new GestionarPagos();
            periodo = servicio.GetPeriodoActivo();
            if (periodo == null)
            {
                MessageBox.Show("No existe el Empleado.");
                limpiarPantalla();
            }
            else
            {
                setDataPeriodo(periodo);
            }
        }
        private void listContratos(List<Contrato> contratos)
        {
            dgvContratos.DataSource = contratos;
        }
        private void setDataPeriodo(Periodo periodo)
        {
            inCodigo.Text = periodo.Id_periodo.ToString();
            inFechaInicio.Text = periodo.FechaInicio.ToString();
            inFechaFin.Text = periodo.FechaFin.ToString();
            inEstado.Text = periodo.Estado ? "Activo" : "No Activo";

        }
        private void disableInputs()
        {
            inCodigo.Enabled = false;
            inFechaInicio.Enabled = false;
            inFechaFin.Enabled = false;
            inEstado.Enabled = false;

        }
        private void limpiarPantalla()
        {
            inCodigo.Text = "";
            inFechaInicio.Text = "";
            inFechaFin.Text = "";
            inEstado.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (periodo != null)
            {
                periodo.Contratos = servicio.GetContratosByPeriodo(periodo);
                //Verificar si periodo puede ser procesado
                if (!periodo.ValidarPeriodoActivos())
                {
                    MessageBox.Show("No se puede procesar el periodo porque la fecha actual debe" +
                                    " ser mayor o igual a la fecha fin del periodo de pago");
                }
                else
                {
                    listContratos(periodo.Contratos);
                }
            }
        }
    }
}
