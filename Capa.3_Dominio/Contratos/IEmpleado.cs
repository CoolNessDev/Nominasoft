using Capa._3_Dominio.Entidades;
using System.Collections.Generic;

namespace Capa._3_Dominio.Contratos
{
    public interface IEmpleado
    {
        Empleado BuscarEmpleadoPorDNI(string DNI);
        Empleado BuscarEmpleado(int id);
        List<Contrato> obtenerContratos(int idEmpleado);
    }
}
