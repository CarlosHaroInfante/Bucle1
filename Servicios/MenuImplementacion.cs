using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle1.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int bucle()
        {
            int numero;  
            Console.WriteLine("Escribe un numero");
            numero = Convert.ToInt32(Console.ReadLine());
           
            
            return numero;

        }

        
    }
}
