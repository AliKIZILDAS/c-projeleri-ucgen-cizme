using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayi giriniz.");
            UcgenCiz(int.Parse(Console.ReadLine()));
        }

        public static void UcgenCiz(int a)
        {
            for (int i = 0; i <2*a; i++)
            {                
                for (int n = 0; n <2*a-i; n++)
                {
                    Console.Write(" ");
                }
                             
                for (int j = 0; j <2*i; j++)
                {
                    Console.Write("*");
                }                               
                Console.WriteLine("");           
            }
        }
    }
}
