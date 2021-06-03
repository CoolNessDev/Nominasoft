using Capa._3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa._3_Dominio.Contratos
{
    public interface IEmpleado
    {
        Empleado BuscarEmpleadoPorDNI(int DNI);
        List<Contrato> obtenerContratos(int idEmpleado);
    }
}
