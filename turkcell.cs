using System;

namespace Cevre_Alan{
    class Program{
        static void Main(string[] args){
            int a,b,cevre,alan;
            Console.Write("Dikdörtgenin birinci kenarını girin:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörtgenin ikinci kenarını girin:");
            b=Convert.ToInt32(Console.ReadLine());
            cevre=2*a+2*b;
            alan=a*b;
            Console.WriteLine("Çevre"+cevre);
            Console.WriteLine("Alan:"+alan);
        }
    }
}