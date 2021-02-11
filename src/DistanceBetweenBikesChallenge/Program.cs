using System;

namespace DistanceBetweenBikesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int quilometros = 0;
            if(Int32.TryParse(Console.ReadLine(), out int K))
            {
               quilometros = K;
                int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
                Console.WriteLine(minutos + " minutos");
            }
            else
            {
                throw new ArgumentException("Digite um valor inteiro para os quilometros");
            }
            
        }
    }
}
