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
           
            int i = a;

            
            
            for (i = a; valor <= 10; ++i) 
            {
            int suma = i + i;
                Console.WriteLine(suma);
            int numero = suma + ++i;
                Console.WriteLine(numero);

                return numero;

                ;
            }
            
            return i;
                //Console.WriteLine(a);
            

            
            

           
            
        }
    }
}
