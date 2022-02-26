using System;

namespace ArraysEhMetodos.ConsoleApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Luciano, você ama sua mãe?\n(1) Sim\n(2) Não");
            int oi = Convert.ToInt32(Console.ReadLine());

            if (oi == 1)
            {
                Console.WriteLine("Eu já sabia que sim, panaca");

            }
        }
    }
}