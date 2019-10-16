using System;

namespace Serra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la temperatura della serra: ");
            double temp = double.Parse(Console.ReadLine());
            if (temp < 5)
            {
                Console.WriteLine("Danni irreparabili");
            }
            else if (5 <= temp && temp < 18)
            {
                Console.WriteLine("Situazione di pericolo");
            }
            else
            {
                Console.WriteLine("Temperatura normale");
            }
            Console.ReadLine();
        }
    }
}
