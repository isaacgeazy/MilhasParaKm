using System;

namespace _12_03
{
    class Program
    {
        static void Main(string[] args)
        {
               string entrada;
               double km = 1.609, resu, milhas;

            Console.ForegroundColor = ConsoleColor.Blue;        
            Console.WriteLine("--------------Conversão de milhas para KM-------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.Write("Digite o valor em milhas: ");
            entrada = Console.ReadLine();

            milhas = Convert.ToDouble(entrada);
            resu = milhas * km;
            Console.WriteLine();
            Console.WriteLine($"{milhas} MILHAS para {resu:N3} KM");
            

            

            
           



        }
    }
}
