using System;

namespace NumberLineChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberChoice;
            int COLUMN = 3;
            int valueNumber = 0;
            int SQUARE = 2;
            int CUBED = 3;
            int[,] lines;

            if (Int32.TryParse(Console.ReadLine(), out int result))
            {
                numberChoice = result;

                while (numberChoice >= 1 && numberChoice <= 1000)
                {
                    lines = new int[numberChoice, COLUMN];

                    for (int i = 0; i < numberChoice; i++)
                    {
                        valueNumber++;

                        for (int j = 0; j < COLUMN; j++)
                        {
                            if ( j == 0)
                            {
                                lines[i,j] = valueNumber;
                            }
                            else if( j == 1)
                                {
                                    lines[i,j] = (int) Math.Pow(valueNumber, SQUARE);
                                }else
                                {
                                    lines[i,j] = (int) Math.Pow(valueNumber, CUBED);
                                }
                        }
                    }
                    for (int i = 0; i < numberChoice; i++)
                    {
                        for (int j = 0; j < COLUMN; j++)
                        {
                            Console.Write($"{lines[i, j]} ");

                            if ( j == 2)
                                Console.Write("\r\n");
                        }
                    }
                    break;
                }
            }
        }
    }
}

