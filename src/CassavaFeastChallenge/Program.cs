using System;

namespace CassavaFeastChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            bool sucess = false;
            const int DEFAULT = 225;

            People chico = new People("Chico", 300);
            People bento = new People("Bento", 1500);
            People bernardo = new People("Bernardo", 600);
            People marina = new People("Marina", 1000);
            People iara = new People("Iara", 150);
            People marlene = new People("Marlene", DEFAULT);

            do
            {
                if (Int32.TryParse(Console.ReadLine(), out int chicoResult) &&
                        Int32.TryParse(Console.ReadLine(), out int bentoResult) &&
                        Int32.TryParse(Console.ReadLine(), out int bernardoResult) &&
                        Int32.TryParse(Console.ReadLine(), out int marinaResult) &&
                        Int32.TryParse(Console.ReadLine(), out int iaraResult)
                    )
                {
                    chico.ServingCassavas = chicoResult;
                    bento.ServingCassavas = bentoResult;
                    bernardo.ServingCassavas = bernardoResult;
                    marina.ServingCassavas = marinaResult;
                    iara.ServingCassavas = iaraResult;

                    sucess = true;
                }
                else
                {
                    Console.WriteLine("É necessário informar o número de gramas de mandioca");
                }


            } while (!sucess);

            total += chico.ServingCassavas + bento.ServingCassavas + bernardo.ServingCassavas + marina.ServingCassavas + iara.ServingCassavas + marlene.ServingCassavas; // Digite aqui o calculo total
            Console.WriteLine(total);
        }
        class People
        {
            private int _servingCassavas;
            public string Name { get; set; }
            public int ServingCassavas
            {
                get => _servingCassavas;
                set => _servingCassavas *= value;
            }

            public People(string name, int servingCassavas)
            {
                Name = name;
                _servingCassavas = servingCassavas;
            }
        }
    }
}

