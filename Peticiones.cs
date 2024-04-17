using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text;

namespace Examen_Segundo_Parcial
{
    class Peticiones
    {
        private int[] dia = new int[2];
        private int[] año = new int[2];
        private string[] mes = new string[2];

        private string[] nombre = new string[2];
        private float[] sueldo = new float[2];

        private int[] diac = new int[2];
        private int[] añoc = new int[2];
        private string[] mesc = new string[2];
        private float suma = 0;
        public void requestnacimiento()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Empleado " + (i+1) + " ingrese su fecha de nacimiento:");
                Console.Write("Dia: ");
                dia[i] = int.Parse(Console.ReadLine());

                Console.Write("Mes : ");
                Meses objeto = new Meses();
                objeto.mesnumero();
                mes[i]=objeto.mesnacimiento();

                Console.Write("Año: ");
                año[i] = int.Parse(Console.ReadLine());
            }
        }
        public void requestnombre()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Empleado " + (i + 1) + " ingrese su nombre:");
                nombre[i] = Console.ReadLine();
            }
        }
        public float requestsueldo()
        {
            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Empleado " + (i + 1) + " ingrese su sueldo:");
                sueldo[i] = float.Parse(Console.ReadLine());
            }
            suma = sueldo[1] - sueldo[0];
            return suma;
        }
        public void requestcontratacion()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Empleado " + (i + 1) + " ingrese su fecha de Contratacion:");
                Console.Write("Dia: ");
                diac[i] = int.Parse(Console.ReadLine());

                Console.Write("Mes : ");
                Meses objeto = new Meses();
                objeto.mesnumero();
                mesc[i] = objeto.mesnacimiento();

                Console.Write("Año: ");
                añoc[i] = int.Parse(Console.ReadLine());
            }
        }
        public void resultados()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(nombre[i] + " Contratado el: " + diac[i] + " de " + mesc[i] + " de " + añoc[i] + " Fecha de Nacimiento: " + dia[i] + " de " + mes[i] + " de " + año[i]);
            }
        }
        public void extra()
        {
            Console.WriteLine("La diferencia de sueldos fue " + suma);
        }
    }
}
