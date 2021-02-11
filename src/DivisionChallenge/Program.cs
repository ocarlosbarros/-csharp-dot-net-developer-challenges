using System;

namespace Chalenges
{
    class Program
    {
        static void Main()
        {
            int limit;
            string[] line;
            bool sucess = false;
            
            if (Int32.TryParse(Console.ReadLine(), out int result))
            {
                limit = result;
            }
            else
            {
                throw new ArgumentException("O valor digitado deve ser inteiro");
            }

            //Repete a operação de acordo com o número digitado pelo usuário
            for (int i = 0; i < limit; i++)
            {
               
                do
                {
                    line = Console.ReadLine().Split(" ");
                     
                     if (line.Length == 1 && double.TryParse(line[0], out double b))
                     {
                        Console.WriteLine();
                        break;
                     }
                     else if (double.TryParse(line[0], out double X) && double.TryParse(line[1], out double Y))
                     {
                        sucess = true;

                        if (Y == 0)
                        {
                            Console.WriteLine("divisao impossivel");
                        }
                        else
                        {
                            double division = X / Y;
                            if (division < 0 && division.ToString("N1") == "0.0")
                            {
                                Console.WriteLine("-0.0");
                            }
                            else
                            {
                                Console.WriteLine(division.ToString("N1"));
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido, digite os valores para realizar a operação de divisão");
                    }

                } while (!sucess);
            }
        }
    }
}