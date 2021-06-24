using Capa._2_Aplicacion.Servicios;
using Capa._3_Dominio.Dto;
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
        bool contratosListados;
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
                contratosListados = false;
            }
        }
        private void listContratos(List<Contrato> contratos)
        {
            dgvContratos.DataSource = contratos;
        }
        private void listPagos(List<CustomPagoDto> pagos)
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

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            if (periodo != null)
            {
                if (!periodo.Estado)
                {
                    MessageBox.Show("Periodo Inactivo");
                }
                else
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
                            contratosListados = true;
                        }
                    }
                }
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            if (periodo != null && periodo.Contratos != null && periodo.Estado && periodo.ValidarPeriodoActivos())
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

                //Listar CustomPagosDto (Usar misma tabla)
                List <Pago> pagos = servicio.GetPagpsByPeriodo(periodo);
                List<CustomPagoDto> customPagos = new List<CustomPagoDto>();

                for (int i = 0; i < pagos.Count; i++)
                {
                    Contrato contrato = servicio.GetContrato(pagos[i].Contrato.Id_contrato);
                    contrato.Periodo = periodo;
                    contrato.ConceptoIngresoDeDescuento = servicio.GetCIDByContrato_Periodo(contrato.Id_contrato, periodo.Id_periodo);
                    Empleado empleado = servicio.BuscarEmpleado(contrato.Empleado.Id_empleado);
                    pagos[i].Contrato = contrato;
                    CustomPagoDto pagoDto = new CustomPagoDto();
                    pagoDto.Id_empleado = empleado.Id_empleado;
                    pagoDto.NombreEmpleado = empleado.Nombre;
                    pagoDto.DniEmpleado = empleado.Dni;
                    pagoDto.TotalHoras = pagos[i].TotalHoras;
                    pagoDto.ValorHora = pagos[i].ValorHora;
                    pagoDto.SueldoMinimo = pagos[i].SueldoMinimo;
                    pagoDto.TotalIngresos = pagos[i].CalcularIngresoTotal();
                    pagoDto.TotalDescuentos = pagos[i].CalcularDescuentoTotal();
                    pagoDto.SueldoNeto = pagos[i].CalcularSueldoNeto();

                    customPagos.Add(pagoDto);
                }

                listPagos(customPagos);

                if (insert)
                {
                    MessageBox.Show("Se generaron los pagos de los contratos");
                }


            }
            if (!periodo.Estado)
            {
                MessageBox.Show("Periodo Inactivo");
            }
            if (!contratosListados)
            {
                MessageBox.Show("No ha seleccionado contratos para realizar el pago");
            }

        }
    }
}
