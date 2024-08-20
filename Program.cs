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

            string data = Console.ReadLine().ToLower(); // Tolower vai converter tudo lido para minúsculo // data = dados
            char type = char.Parse(data.Substring(data.Length-1,1)); // Converte a parte expecificada da string(substring em um char) (posição,quantidade)
            //data.lenght trará a quantidade digitada, como arrays começam a partir de 0 e o lenght conta a partir do 1 portanto para pegar a ultima posição do array é necessário subtrair 1 do lenght
            Console.WriteLine(data);
            Console.WriteLine(type);
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
