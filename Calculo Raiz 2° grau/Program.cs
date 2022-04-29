using System;

namespace Calculo_Raiz_2__grau
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            double delta, x, xnegativo;


            Console.WriteLine("Vamos calcular as raizes da equação :-)");
            Console.WriteLine("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * (-c);
            
            if (delta >= 0)
            {
                if (delta == 0)
                {
                    x = (-b + Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("O valor da raiz encontrado foi," + x );
                }
                else
                {
                    x = (-b + Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("O valor da raiz encontrado foi " + x);

                    xnegativo = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("O valor da raiz encontrado foi " +  xnegativo);

                }


            }
            else
            {
                Console.WriteLine("o delta encontrado não fornece valores reais");

            }
             
          

        }

    }
}
