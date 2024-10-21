using System;

namespace EstudoSharp
{
    class Zoo
    {
        public Zoo()
        {


            string[] pettingZoo =
            {
    "alpacas", "capivaras", "galinhas", "patos", "emus", "gansos",
    "cabras", "iguanas", "canguru", "lemure", "llamas", "papagaio",
    "avestruz", "porco", "ponies", "coelhos", "ovelhas", "tartarugas",
};

            PlanSchoolVisit("Escola A");
            PlanSchoolVisit("Escola B", 3);
            PlanSchoolVisit("Escola C", 2);

            void PlanSchoolVisit(string schoolName, int groups = 6)
            {
                RandomizeAnimals();
                string[,] group1 = AssignGroup(groups);
                Console.WriteLine(schoolName);
                PrintGroup(group1);
            }

            void RandomizeAnimals()
            {
                Random random = new Random();

                for (int i = 0; i < pettingZoo.Length; i++)
                {
                    int r = random.Next(i, pettingZoo.Length);

                    string temp = pettingZoo[r];
                    pettingZoo[r] = pettingZoo[i];
                    pettingZoo[i] = temp;
                }
            }

            string[,] AssignGroup(int groups = 6)
            {
                string[,] result = new string[groups, pettingZoo.Length / groups];
                int start = 0;

                for (int i = 0; i < groups; i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i, j] = pettingZoo[start++];
                    }
                }

                return result;
            }

            void PrintGroup(string[,] groups)
            {
                for (int i = 0; i < groups.GetLength(0); i++)
                {
                    Console.Write($"Grupo {i + 1}: ");
                    for (int j = 0; j < groups.GetLength(1); j++)
                    {
                        Console.Write($"{groups[i, j]}  ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
