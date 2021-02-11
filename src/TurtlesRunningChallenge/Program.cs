using System;

namespace TurtleRunningRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int turtleNumber;
            int[] turtleSpeeds;
            int maxSpeed = 0;

            if (Int32.TryParse(Console.ReadLine(), out int result) && result >= 1 && result <= 500)
            {
                turtleNumber = result;
                turtleSpeeds = new int[result];

                for (int i = 0; i < turtleSpeeds.Length; i++)
                {
                    if (Int32.TryParse(Console.ReadLine(), out int resultSpeed))
                    {
                        turtleSpeeds[i] = resultSpeed;

                        for (int j = 0; j < turtleSpeeds.Length; j++)
                        {
                            if (turtleSpeeds[j] > maxSpeed)
                            {
                                maxSpeed = turtleSpeeds[j];
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Digite um número inteiro entre 1 e 500.");
                    }
                }
                if (maxSpeed < 10)
                {
                    Console.WriteLine(1);
                }
                else if (maxSpeed >= 20)
                {
                    Console.WriteLine(3);
                }
                else
                {
                    Console.WriteLine(2);
                }
            }
            else
            {
                Console.WriteLine("Digite um número inteiro entre 1 e 500.");
            }
        }
    }
}


