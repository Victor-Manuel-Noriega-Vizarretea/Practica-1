using System;

namespace Bitacora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float desicion;
            int b1 = 0;
            Random r = new Random();
            Console.WriteLine("NOTA: SI=1   NO=2");
            Console.WriteLine("¿ Desea ingresar en un ciclo ?");
            desicion = Convert.ToSingle(Console.ReadLine());
            if (desicion == 1)
            {
                Console.WriteLine("Cauntos numeros quiere imprimir: ");
                b1 = int.Parse(Console.ReadLine());
                for (int i = 0; i < b1; i++) 
                {
                    Console.WriteLine("Su numero es: " + (r.Next(1, 100)));
                }
            }else if (desicion == 2)
            {
                Console.WriteLine("Que tenga un buen dia");
            }


        }
    }
}
