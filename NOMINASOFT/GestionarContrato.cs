using Capa._2_Aplicacion.Servicios;
using Capa._3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NOMINASOFT
{
    public partial class GestionarContrato : Form
    {

        Boolean EDITAR = false;
        Empleado empleado = null;
        int auxIdContrato = 0; //guarda el id del ultimo contrato
        Contrato contrato;
        public GestionarContrato()
        {
            contrato = new Contrato();
            InitializeComponent();
            btnGuardarContrato.Enabled = false;
            banularInterno.Enabled = false;
        }
        private void configuracionDeDatosContrato()
        {
            PanelDatosContrato.Visible = true;
            Size = new System.Drawing.Size(715, 715);
            panel5.Visible = true;
            btnCrearContrato.Location = new Point(187, 641);
            btnEditarContrato.Location = new Point(314, 641);
            btnAnularContrato.Location = new Point(439, 641);
        }
        private void configuracionInternaDeDatosContrato()
        {
            Size = new System.Drawing.Size(715, 455);
            panel5.Visible = false;
            PanelDatosContrato.Visible = false;
            btnCrearContrato.Location = new Point(187, 381);
            btnEditarContrato.Location = new Point(314, 381);
            btnAnularContrato.Location = new Point(439, 381);
        }
        private void limpiarPantalla()
        {
            textDniBuscar.Text = "";
            textDireccionResultado.Text = "";
            textEstadoCResultado.Text = "";
            textFechaResultado.Value = DateTime.Now;
            textGradoResultado.Text = "";
            textNombreResultado.Text = "";
            textTelefonoResultado.Text = "";
            textIDResultado.Text = "";
            //-----------------------------------
            cbAFP.Text = "";
            TextCargo.Text = "";
            fechaInicio.Value = DateTime.Now;
            fechaFinal.Value = DateTime.Now;
            textTotalDeHoras.Text = "";
            textValorHora.Text = "";

        }
        private bool mostrarContrato()
        {

            GestionarContratos servicio = new GestionarContratos();
            contrato = servicio.MostrarContratos(int.Parse(textIDResultado.Text.Trim()));
            if (contrato != null)
            {
                auxIdContrato = contrato.Id_contrato;
                Afp afp = servicio.BuscarAFPCodigo(contrato.Afp.Id_afp);
                if (afp != null)
                {
                    cbAFP.Text = afp.Nombre;
                    TextCargo.Text = contrato.Cargo;
                    fechaInicio.Value = contrato.FechaInicio;
                    fechaFinal.Value = contrato.FechaFin;
                    textTotalDeHoras.Text = contrato.HorasContratadasPorSemana.ToString();
                    textValorHora.Text = contrato.ValorHora.ToString();
                    AsignacionSI.Checked = contrato.AsignacionFamiliar;
                    AsignacionNO.Checked = !contrato.AsignacionFamiliar;
                    return true;
                }
            }
            return false;
        }
        private void inavilitarDatosContrato()
        {

            AsignacionSI.Enabled = false;
            AsignacionNO.Enabled = false;
            cbAFP.Enabled = false;
            TextCargo.Enabled = false;
            fechaInicio.Enabled = false;
            fechaFinal.Enabled = false;
            textTotalDeHoras.Enabled = false;
            textValorHora.Enabled = false;
        }
        private void avilitarDatosContrato()
        {
            AsignacionSI.Enabled = true;
            AsignacionNO.Enabled = true;
            cbAFP.Enabled = true;
            TextCargo.Enabled = true;
            fechaInicio.Enabled = true;
            fechaFinal.Enabled = true;
            textTotalDeHoras.Enabled = true;
            textValorHora.Enabled = true;
        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            string dniEmpleado = textDniBuscar.Text.Trim();
            if (textDniBuscar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Los Datos Del Empleado");
            }
            else
            {
                GestionarContratos servicio = new GestionarContratos();
                empleado = servicio.BuscarEmpleado(dniEmpleado);
                if (empleado == null)
                {
                    MessageBox.Show("No existe el Empleado.");
                    limpiarPantalla();
                }
                else
                {
                    textDireccionResultado.Text = empleado.Direccion;
                    textEstadoCResultado.Text = empleado.EstadoCivil;
                    textFechaResultado.Value = empleado.FechaNacimiento;
                    textGradoResultado.Text = empleado.GradoAcademico;
                    textNombreResultado.Text = empleado.Nombre;
                    textTelefonoResultado.Text = empleado.Telefono.ToString();
                    textIDResultado.Text = empleado.Id_empleado.ToString();
                }
            }
        }

        private void btnCrearContrato_Click(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                GestionarContratos servicio = new GestionarContratos();
                Contrato contratoEmpleado = servicio.MostrarContratos(empleado.Id_empleado);
                if (contratoEmpleado == null)
                {
                    EDITAR = false;
                    inavilitarDatosContrato();
                    avilitarDatosContrato();
                    configuracionDeDatosContrato();
                    btnEditarContrato.Enabled = false;
                    btnAnularContrato.Enabled = false;
                    btnGuardarContrato.Enabled = true;
                    banularInterno.Enabled = false;
                    avilitarDatosContrato();
                }
                else
                {
                    MessageBox.Show("ya tiene un contrato vigente");
                }

            }

        }

        private void btnEditarContrato_Click(object sender, EventArgs e)
        {
            if (textIDResultado.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Los Datos Del Empleado");
            }
            else
            {
                bool contratoObtenido = mostrarContrato();
                if (contratoObtenido)
                {
                    EDITAR = true;
                    configuracionDeDatosContrato();
                    btnCrearContrato.Enabled = false;
                    btnAnularContrato.Enabled = false;
                    btnGuardarContrato.Enabled = true;
                    banularInterno.Enabled = false;
                    avilitarDatosContrato();
                }
                else
                {
                    MessageBox.Show("No existe un contrato vigente");
                }
            }
        }

        /// <summary>
        /// Funcion vacia
        /// </summary>
        private void AsignacionSI_CheckedChanged(object sender, EventArgs e)
        {
            //NotImplemented
        }
        /// <summary>
        /// Funcion vacia
        /// </summary>
        private void AsignacionNO_CheckedChanged(object sender, EventArgs e)
        {
            //NotImplemented
        }

        private void AFPSI_CheckedChanged(object sender, EventArgs e)
        {
            cbAFP.Enabled = true;
        }

        private void AFPNO_CheckedChanged(object sender, EventArgs e)
        {
            cbAFP.Enabled = false;
        }

        private void GestionarContrato_Load(object sender, EventArgs e)
        {
            configuracionInternaDeDatosContrato();
            llenarComboBoxAfp();
        }
        private void llenarComboBoxAfp()
        {
            GestionarContratos servicio = new GestionarContratos();
            List<Afp> listarAfp = servicio.llenarComboBoxAFP();

            foreach (Afp afp in listarAfp)
            {
                cbAFP.Items.Add(afp.Nombre);
            }
        }

        private void btnGuardarContrato_Click(object sender, EventArgs e)
        {
            GestionarContratos servicio = new GestionarContratos();

            Contrato nuevoContrato = new Contrato();
            nuevoContrato.Id_contrato = auxIdContrato;
            nuevoContrato.AsignacionFamiliar = AsignacionSI.Checked;


            try
            {
                nuevoContrato.Cargo = TextCargo.Text.Trim();
                nuevoContrato.FechaInicio = fechaInicio.Value.Date;
                nuevoContrato.FechaFin = fechaFinal.Value.Date;
                nuevoContrato.HorasContratadasPorSemana = int.Parse(textTotalDeHoras.Text.Trim());
                nuevoContrato.ValorHora = int.Parse(textValorHora.Text.Trim());
                nuevoContrato.Estado = true;
                Afp afp = servicio.BuscarAFP(cbAFP.Text.Trim());
                if (afp != null)
                {
                    nuevoContrato.Afp = afp;

                    Empleado empleadoContrato = servicio.BuscarEmpleado(textDniBuscar.Text.Trim());
                    if (empleadoContrato != null)
                    {
                        nuevoContrato.Empleado = empleadoContrato;
                    }
                }
            }
            catch (Exception)
            {
                showError("Campos invalidos");
                return;
            }
            if (!nuevoContrato.ValidarVigenciaContrato())
            {
                showError("Contrato no vigente");
                return;
            }
            if (!nuevoContrato.ValidarFechaInicioContrato())
            {
                showError("El contrato anterior es aún vigente");
                return;
            }
            if (!nuevoContrato.ValidarFechaFinContrato())
            {
                showError("Fecha final no valida");
                return;
            }
            if (!nuevoContrato.ValidarHoras())
            {
                showError("El valor de horas por semana no es válido");
                return;
            }
            if (!nuevoContrato.ValidarValorHoras())
            {
                showError("El valor de hora no es válido");
                return;
            }


            try
            {
                if (EDITAR)
                {
                    servicio.EditarContratos(nuevoContrato, int.Parse(textIDResultado.Text.Trim()));
                }
                else
                {
                    servicio.GuardarContratos(nuevoContrato);
                    Contrato contratoInsertado = servicio.MostrarContratos(empleado.Id_empleado);
                    Periodo periodo = servicio.GetPeriodoActivo();
                    bool insertPeriodoContrato = servicio.InsertarContratoPeriodo(contratoInsertado.Id_contrato, periodo.Id_periodo);
                    if (insertPeriodoContrato)
                    {
                        MessageBox.Show("Periodo_Contrato Insertado");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema NominaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            configuracionInternaDeDatosContrato();
            btnCrearContrato.Enabled = true;
            btnAnularContrato.Enabled = true;
            btnEditarContrato.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            configuracionInternaDeDatosContrato();

            cbAFP.Text = "";
            TextCargo.Text = "";
            fechaInicio.Value = DateTime.Now;
            fechaFinal.Value = DateTime.Now;
            textTotalDeHoras.Text = "";
            textValorHora.Text = "";
            btnGuardarContrato.Enabled = false;
            banularInterno.Enabled = false;
            btnCrearContrato.Enabled = true;
            btnAnularContrato.Enabled = true;
            btnEditarContrato.Enabled = true;
        }

        private void btnAnularContrato_Click(object sender, EventArgs e)
        {
            bool contratoEncontrado = mostrarContrato();
            if (contratoEncontrado)
            {
                btnCrearContrato.Enabled = false;
                btnEditarContrato.Enabled = false;
                btnGuardarContrato.Enabled = false;
                banularInterno.Enabled = true;
                inavilitarDatosContrato();
                configuracionDeDatosContrato();
            }
        }

        private void banularInterno_Click(object sender, EventArgs e)
        {
            GestionarContratos servicio = new GestionarContratos();
            contrato.Estado = false;
            servicio.EditarContratos(contrato, int.Parse(textIDResultado.Text.Trim()));
            configuracionInternaDeDatosContrato();
            btnCrearContrato.Enabled = true;
            btnAnularContrato.Enabled = true;
            btnEditarContrato.Enabled = true;
        }
        private void showError(string message)
        {
            Exception err = new Exception(message);
            MessageBox.Show(this, err.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Funcion vacia
        /// </summary>
        private void Panel5_Paint(object sender, PaintEventArgs e)
        {
            //NotImplemented
        }
    }
}
