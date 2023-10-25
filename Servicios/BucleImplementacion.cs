using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bucle1.Servicios
{
    internal class BucleImplementacion : BucleInterfaz
    {
        public int bucle2(int valor)
        {
            MenuInterfaz potaje = new MenuImplementacion();
            //int a = potaje.bucle();
            int a = valor;
            int suma;
            suma = (a);
            for (a = a; a <= 10; ++a) 
            {
            Console.WriteLine(a);

                //Console.WriteLine(a);
            }

            for (a = suma; a<=10; ++suma)
            {
                Console.WriteLine(suma);
            }
            return a;
            
        }
    }
}
