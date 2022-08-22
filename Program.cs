using System;

namespace ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            TimeSpan segundos = TimeSpan.FromSeconds(entrada);
            int horas =(((segundos.Days * 24) + segundos.Hours));

            Console.WriteLine($"{horas.ToString("00")}:{segundos.Minutes.ToString("00")}:{segundos.Seconds.ToString("00")}");
        }
    }
}
