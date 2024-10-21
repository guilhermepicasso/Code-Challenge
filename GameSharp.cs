using System;

namespace EstudoSharp
{
    class GameSharp
    {
        public GameSharp()
        {
            Random random = new Random();

            Console.WriteLine("Gostaria de Jogar? (Y/N)");
            if (ShouldPlay())
                PlayGame();

            bool ShouldPlay()
            {
                string response = Console.ReadLine();
                return response.ToLower().Equals("y");
            }

            void PlayGame()
            {
                var play = true;

                while (play)
                {
                    var target = GetTarget();
                    var roll = RollDice();

                    Console.WriteLine($"Role um número superior a {target} para vencer !");
                    Console.WriteLine($"Seu número foi {roll}");
                    Console.WriteLine(WinOrLose(roll, target));
                    Console.WriteLine("\njogar de novo ? (Y/N)");

                    play = ShouldPlay();
                }
            }

            int GetTarget()
            {
                return random.Next(1, 6);
            }

            int RollDice()
            {
                return random.Next(1, 7);
            }

            string WinOrLose(int roll, int target)
            {
                if (roll > target)
                    return "Você venceu!";
                return "Você perdeu";
            }
        }
    }
}
