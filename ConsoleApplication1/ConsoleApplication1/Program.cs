using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Class1 obj = new Class1();
            Console.WriteLine("Ingrese un valor para inciar el proceso: ");
            Console.WriteLine("1) Para multipicar dos enteros: ");
            Console.WriteLine("2) Para dividr dos numeros enteros: ");
            Console.WriteLine("3) Para capturar 5 nombres: ");
            Console.WriteLine("4) Para capturar 5 edades: ");
            int N = int.Parse(Console.ReadLine());
            if (N == 1)
            {
                obj.primer();
            }
            else if(N==2)
            {
                obj.segundo();
            }
            else if (N==3)
            {
                obj.tercer();
            }
            else if (N == 4)
            {
                obj.cuarto();
            }
            else
            { Console.WriteLine("A ingresado un numero no valido "); }

            Console.ReadKey();
        }
    }
}
