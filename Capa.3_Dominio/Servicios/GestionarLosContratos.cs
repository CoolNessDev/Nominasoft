using Capa._3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa._3_Dominio.Servicios
{
    public class GestionarLosContratos
    {
        public bool ValidarContrato(Contrato contrato)
        {
            bool estadito = true;

            if (!contrato.ValidarFechaFinContrato())
            {
                MessageBox.Show("La Fecha Final Es incorrecta");
                estadito = false;
            }
            if (!contrato.ValidarHoras())
            {
                MessageBox.Show("La Hora contratadas por semana es Incorrecta");
                estadito = false;
            }
            if(!contrato.ValidarValorHoras())
            {
                MessageBox.Show("El Valor Hora es Incorrecto");
                estadito = false;
            }
            return estadito;
        }
    }
}
