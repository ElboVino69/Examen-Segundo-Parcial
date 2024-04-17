using System;

namespace Examen_Segundo_Parcial
//programa que solicite:
// -Fecha de nacimiento del empleado(dia, mes y año)
// -Nombre del Empleado
// -Sueldo
// -Fecha de contratación(dia, mes y año)
//Regresar
// -Nombre del Empleado
// -Fecha de contratación(dia, mes y año)
// -Fecha de nacimiento del empleado(dia, mes y año)
// -Diferencia de sueldos
{
    class Program
    {
        static void Main(string[] args)
        {
            Peticiones objeto = new Peticiones();
            objeto.requestnacimiento();
            objeto.requestnombre();
            objeto.requestsueldo();
            objeto.requestcontratacion();
            objeto.resultados();
            objeto.extra();
        }
    }
}
