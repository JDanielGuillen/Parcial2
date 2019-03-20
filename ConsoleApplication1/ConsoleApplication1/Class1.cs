using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        int n1, n2 = 0, totalS, e=1 ;
        string[] nombres = new string[6];
        int[] edad = new int[6];



        public void primer()
        {
            Console.WriteLine("Ingrese el primer valor: ");
            n1 = int.Parse(Console.ReadLine());
            if (n1 != 0)
            {
                Console.WriteLine("Ingrese el segundo valor: ");
                n2 = int.Parse(Console.ReadLine());
                totalS = n1 * n2;
                Console.WriteLine("El total es: " + totalS);
            }
            else if (n1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0 ");
            }

        }
        public void segundo()
        {
            Console.WriteLine("Ingrese el primer valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            n2 = int.Parse(Console.ReadLine());
            if (n2 != 0)
            {
                
                totalS = n1 / n2;
                Console.WriteLine("El total es: " + totalS);
            }
            else if (n2 == 0)
            {
                Console.WriteLine("Error no se puede dividir entre cero ");
            }

        }
        public void tercer()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Ingrese el " + i + ") nombre: ");
                nombres[i] = Console.ReadLine();
            }
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i + ")" + nombres[i]);

            }

        }
        public void cuarto()
        {
            do
            {
                

                Console.WriteLine("Ingrese la " + e + ") edad : ");
                edad[e] = int.Parse(Console.ReadLine());
                e = e + 1;

            } while (e < 6);
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i + ") edad: " + edad[i]);
            }
        }

    }
}
