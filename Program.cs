using System;
using System.Threading; // Classe de gerenciamento de thrads

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // Tolower vai converter tudo lido para minúsculo
            Console.WriteLine(data);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while( currentTime != time)
            {
                Console.Clear();
                currentTime++;  
                Console.WriteLine(currentTime); 
                Thread.Sleep(1000); // Thread.Sleep(1000); em C# faz com que a thread atual (onde o código está sendo executado) pause ou "durma" por um tempo especificado, antes de continuar a execução do próximo código. Esse tempo é medido em milissegundos.
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
        }
    }
}
