using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Segundo_Parcial
{
    class Meses
    {
        private int mesnum = new int();
        public int mesnumero()
        {
                mesnum = int.Parse(Console.ReadLine());
            return mesnum;
        }
        public string mesnacimiento()
        {
            switch(mesnum)
            {
                case 1:
                        return "Enero";
                case 2:
                        return "Febrero";
                case 3:
                        return "Marzo";
                case 4:
                        return "Abril";
                case 5:
                        return "Mayo";
                case 6:
                        return "Junio";
                case 7:
                        return "Julio";
                case 8:
                        return "Agosto";
                case 9:
                        return "Septiembre";
                case 10:
                        return "Octubre";
                case 11:
                        return "Noviembre";
                case 12:
                        return "Diciembre";
                default:
                    return "El valor ingresado no se encuentra entre los meses existentes, intente de nuevo";
            }
        }

    }
}
