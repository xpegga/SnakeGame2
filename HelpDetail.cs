using System;

namespace SnakeGame2
{
    public class HelpDetail
    {
        public HelpDetail(){

        }
        public void ShowHelpDetail(){
            bool endShowHelpDetail = false;
            int userSelect;
            do{
                Console.Clear();
                Console.WriteLine("### Help Detail ###");
                Console.Write("Control Movement: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Arrow Key");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Snake body: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Food: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("^");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Special Food: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("S");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("God Food: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("G");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Eat food will increase 1 score");
                Console.WriteLine("Eat special food will increase 1 life");
                Console.WriteLine("Eat god food will turn into god mode body will change to cyan color");
                Console.WriteLine("Hit obstacle will decrease 1 life if life equal to 0, game will end");
                Console.WriteLine("When game end score reach top 10 score in score board, score will be recorded");
                Console.WriteLine("Game Difficult: Easy");
                Console.WriteLine("Food Change Location Time: 200 steps");
                Console.WriteLine("Special Food Change Location Time: 200 steps");
                Console.WriteLine("God Food Change Location Time: 200 steps");
                Console.WriteLine("God Mode Time: 150 steps");
                Console.WriteLine("Obstacle Change Time: 150 steps");
                Console.WriteLine("Game Difficult: Normal");
                Console.WriteLine("Food Change Location Time: 150 steps");
                Console.WriteLine("Special Food Change Location Time: 150 steps");
                Console.WriteLine("God Food Change Location Time: 150 steps");
                Console.WriteLine("God Mode Time: 100 steps");
                Console.WriteLine("Obstacle Change Time: 100 steps");
                Console.WriteLine("Game Difficult: Hard");
                Console.WriteLine("Food Change Location Time: 100 steps");
                Console.WriteLine("Special Food Change Location Time: 100 steps");
                Console.WriteLine("God Food Change Location Time: 100 steps");
                Console.WriteLine("God Mode Time: 50 steps");
                Console.WriteLine("Obstacle Change Time: 50 steps");
                Console.WriteLine("Type 1 to exit");
                userSelect = Convert.ToInt32(Console.ReadLine());
                if(userSelect == 1){
                    endShowHelpDetail = true;
                }
            }while(!endShowHelpDetail);
        }
    }
}