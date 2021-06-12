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
        GestionarContratos servicioContratos;
        Periodo periodo;
        public ProcesarPago()
        {
            InitializeComponent();
            disableInputs();
            servicio = new GestionarPagos();
            servicioContratos = new GestionarContratos();
            periodo = servicio.GetPeriodoActivo();
            if (periodo == null)
            {
                MessageBox.Show("No se puede procesar porque no existe un periodo de" +
                                "pago activo.");
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
        private void listPagos(List<Pago> pagos)
        {
            dgvContratos.DataSource = pagos;
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
                if (periodo.Contratos.Count <= 0)
                {
                    MessageBox.Show("No se puede procesar porque no existen contratos.");
                }
                else
                {
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (periodo != null && periodo.Contratos != null)
            {
                bool insert = false;
                for (int i = 0; i < periodo.Contratos.Count; i++)
                {
                    periodo.Contratos[i].Afp = servicioContratos.BuscarAFPCodigo(periodo.Contratos[i].Afp.Id_afp);
                    Pago pago = new Pago();
                    pago.Periodo = periodo;
                    pago.Contrato = periodo.Contratos[i];
                    pago.FechaActual = DateTime.Now;
                    pago.ValorHora = periodo.Contratos[i].ValorHora;
                    pago.TotalHoras = pago.CalcularTotalDeHoras();
                    pago.SueldoMinimo = pago.CalcularSueldoBasico();
                    pago.MontoAsignacionFamiliar = pago.CalcularMontoPorAsignacionFamiliar();
                    pago.PorcentajeDescuento = periodo.Contratos[i].Afp.Porsentaje_descuento;
                    pago.DescuentAFP = pago.CalcularDescuentoAFP();
                    insert = servicio.registerPago(pago);

                }
                //Cambio de estado del periodo
                periodo.Estado = false;
                bool update = servicio.updatePeriodo(periodo);
                if (update)
                {
                    setDataPeriodo(periodo);

                }


                //FAltA FORMATEAR TABLA PARA QUE SALGAN EXACTAMENTE LOS SIGUIENTES DATOS DEL PAGO:
                //código del empleado, nombre del empleado, dni del empleado, el total de horas, el valor
                //hora, el sueldo básico, el total de ingresos, el total de descuento y el sueldo neto.
                //(El contrato en la clase Pago debe traer son datos del empleado en Contrato.Empleado.
                //Actualmente solo guarda su codigo en Contrato.Empleado.IdEmpleado)


                //Listar pagos (Usar misma tabla)
                List<Pago> pagos = servicio.GetPagpsByPeriodo(periodo);
                listPagos(pagos);
                if (insert)
                {
                    MessageBox.Show("Se generaron los pagos de los contratos");
                }


            }

        }
    }
}
