using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("WSB");
            Console.WriteLine("Nowa Linia");

            Console.Write("Proszę podaj swoje imię: ");
            //typ string
            string name = Console.ReadLine();

            Console.WriteLine("Masz na imię: ");
            Console.WriteLine(name);

            //typ integer
            int age = 20;
            Console.WriteLine(age);

            uint number = 10;

            //typ float
            float z = 14.55F;
            //+ konkatenacja
            Console.WriteLine("Zmienna z wynosi: " + z);

            Console.WriteLine("Program obliczający pole prostokąta");
            Console.WriteLine("Podaj bok a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b: ");
            float b = float.Parse(Console.ReadLine());         
            Console.WriteLine("Wynik wynosi: " + a * b);

            int j, k = 10, l;

            //int zmienna = 10
            int zmienna = new int();










            Console.ReadKey();
            
        }
    }
}
