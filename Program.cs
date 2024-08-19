using System;
using System.Threading; // Classe de gerenciamento de thrads

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start(){
            int time = 10;
            int currentTime = 0;

            while( currentTime != time)
            {
                Console.Clear();
                currentTime++;  
                Console.WriteLine(currentTime); 
                Thread.Sleep(1000); // Thread.Sleep(1000); em C# faz com que a thread atual (onde o código está sendo executado) pause ou "durma" por um tempo especificado, antes de continuar a execução do próximo código. Esse tempo é medido em milissegundos.
                
            }
        }
    }
}
