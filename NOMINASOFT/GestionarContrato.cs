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
    public partial class GestionarContrato : Form
    {

        Boolean EDITAR = false;
        int auxIdContrato = 0;
        public GestionarContrato()
        {
            InitializeComponent();
            button5.Enabled = false;
            banularInterno.Enabled = false;
        }
        private void configuracionDeDatosContrato()
        {
            PanelDatosContrato.Visible = true;
            Size = new System.Drawing.Size(715, 715);
            panel5.Visible = true;
            bCrear.Location = new Point(187, 641);
            bEditar.Location = new Point(314, 641);
            bAnular.Location = new Point(439, 641);
        }
        private void configuracionInternaDeDatosContrato()
        {
            Size = new System.Drawing.Size(715, 455);
            panel5.Visible = false;
            PanelDatosContrato.Visible = false;
            bCrear.Location = new Point(187, 381);
            bEditar.Location = new Point(314, 381);
            bAnular.Location = new Point(439, 381);
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
        private void mostrarContrato()
        {

                GestionarContratos servicio = new GestionarContratos();
                Contrato contrato = servicio.MostrarContratos(int.Parse(textIDResultado.Text.Trim()));
            auxIdContrato = contrato.Id_contrato;
            /*if(contrato.AsignacionFamiliar == true)
            {
                AsignacionSI.Checked = true;
            }
            if(contrato.AsignacionFamiliar == false)
            {
                AsignacionNO.Checked = true;
            }*/
            Afp afp = servicio.BuscarAFPCodigo(contrato.Afp.Id_afp);
                cbAFP.Text = afp.Nombre;
                TextCargo.Text = contrato.Cargo;
                fechaInicio.Value = contrato.FechaInicio;
                fechaFinal.Value = contrato.FechaFin;
                textTotalDeHoras.Text = contrato.HorasContratadasPorSemana.ToString();
                textValorHora.Text = contrato.ValorHora.ToString();
                AsignacionSI.Checked = contrato.AsignacionFamiliar;
                AsignacionNO.Checked = !contrato.AsignacionFamiliar;


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
        private void bBuscar_Click(object sender, EventArgs e)
        {
            string dniEmpleado = textDniBuscar.Text.Trim();
            if(textDniBuscar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Los Datos Del Empleado");
            }
            else
            {
                GestionarContratos servicio = new GestionarContratos();
                Empleado empleado = servicio.BuscarEmpleado(dniEmpleado);
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

        private void bCrear_Click(object sender, EventArgs e)
        {
            configuracionDeDatosContrato();
            bEditar.Enabled = false;
            bAnular.Enabled = false;
            button5.Enabled = true;
            banularInterno.Enabled = false;
            avilitarDatosContrato();
        }
        
        private void bEditar_Click(object sender, EventArgs e)
        {
            if (textIDResultado.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Los Datos Del Empleado");
            }
            else
            {
                mostrarContrato();
                EDITAR = true;
                configuracionDeDatosContrato();
                bCrear.Enabled = false;
                bAnular.Enabled = false;
                button5.Enabled = true;
                banularInterno.Enabled = false;
                avilitarDatosContrato();
            }
        }

        private void AsignacionSI_CheckedChanged(object sender, EventArgs e){}

        private void AsignacionNO_CheckedChanged(object sender, EventArgs e){}

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

        private void button5_Click(object sender, EventArgs e)
        {
            GestionarContratos servicio = new GestionarContratos();

            Contrato contrato = new Contrato();
            contrato.Id_contrato = auxIdContrato;
            if (AsignacionSI.Checked == true )
            {
                contrato.AsignacionFamiliar = true;
            }
            if(AsignacionNO.Checked == true)
            {
                contrato.AsignacionFamiliar =false;
            }

            try{
                contrato.Cargo = TextCargo.Text.Trim();
                contrato.FechaInicio = fechaInicio.Value.Date;
                contrato.FechaFin = fechaFinal.Value.Date;
                contrato.HorasContratadasPorSemana = int.Parse(textTotalDeHoras.Text.Trim());
                contrato.ValorHora = int.Parse(textValorHora.Text.Trim());
                contrato.Estado = true;
                Afp afp = new Afp();
                afp = servicio.BuscarAFP(cbAFP.Text.Trim());
                contrato.Afp = afp;

                Empleado empleado = new Empleado();
                empleado = servicio.BuscarEmpleado(textDniBuscar.Text.Trim());
                contrato.Empleado = empleado;
            }
            catch(Exception exce)
            {
                showError("Campos invalidos");
                return;
            }
            if (!contrato.ValidarVigenciaContrato())
            {
                showError("Contrato no vigente");
                return;
            }
            if (!contrato.ValidarFechaInicioContrato())
            {
                showError("El contrato anterior es aún vigente");
                return;
            }if (!contrato.ValidarFechaFinContrato())
            {
                showError("Fecha final no valida");
                return;
            }if (!contrato.ValidarHoras())
            {
                showError("El valor de horas por semana no es válido");
                return;
            }if (!contrato.ValidarValorHoras())
            {
                showError("El valor de hora no es válido");
                return;
            }
            

            try
            {
                if (EDITAR == true)
                {
                    servicio.EditarContratos(contrato, int.Parse(textIDResultado.Text.Trim()));
                }
                else
                {
                    servicio.GuardarContratos(contrato);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema NominaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            limpiarPantalla();
            configuracionInternaDeDatosContrato();
            bCrear.Enabled = true;
            bAnular.Enabled = true;
            bEditar.Enabled = true;

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
            button5.Enabled = false;
            banularInterno.Enabled = false;
            bCrear.Enabled = true;
            bAnular.Enabled = true;
            bEditar.Enabled = true;
        }
        
        private void bAnular_Click(object sender, EventArgs e)
        {
            mostrarContrato();
            bCrear.Enabled = false;
            bEditar.Enabled = false;
            button5.Enabled = false;
            banularInterno.Enabled = true;
            inavilitarDatosContrato();
            configuracionDeDatosContrato();
        }

        private void banularInterno_Click(object sender, EventArgs e)
        {
            GestionarContratos servicio = new GestionarContratos();
            Contrato contrato = new Contrato();
            contrato.Estado = false;
            servicio.AnularContratos(contrato, int.Parse(textIDResultado.Text.Trim()));
            limpiarPantalla();
            configuracionInternaDeDatosContrato();
            bCrear.Enabled = true;
            bAnular.Enabled = true;
            bEditar.Enabled = true;
        }
        private void showError(string message)
        {
            Exception err = new Exception(message);
            MessageBox.Show(this, err.Message, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
