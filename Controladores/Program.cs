namespace Bucle1;

using Bucle1.Servicios;

class Program
{
    static void Main(string[] args)
    {
        MenuInterfaz a = new MenuImplementacion();
        int c = a.bucle();
        
        //int i = a.bucle();
        


        BucleInterfaz chicharo = new BucleImplementacion();

        int resultado = chicharo.bucle2(c);
    }
}
