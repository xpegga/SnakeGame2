using System;

namespace SnakeGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endProgram = false;
            int userSelect;
            GameDifficult gameDifficult = new GameDifficult();
            Gameplay gameplay = new Gameplay();
            ScoreBoard scoreBoard = new ScoreBoard();
            HelpDetail helpDetail = new HelpDetail();
            do{
                Console.Clear();
                Console.WriteLine("Welcome to Snake Game\n");
                Console.WriteLine("### Snake Game Main Menu ###");
                Console.WriteLine("1. Play Game");
                string showDifficult = "";
                if(gameDifficult.Difficult == 1){
                    showDifficult = "Easy";
                }else if(gameDifficult.Difficult == 2){
                    showDifficult = "Normal";
                }else if(gameDifficult.Difficult == 3){
                    showDifficult = "Hard";
                }
                Console.WriteLine($"2. Change Game Difficult: {showDifficult}");
                Console.WriteLine("3. Show Score Board");
                Console.WriteLine("4. Help Detail");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please type the number");
                userSelect = Convert.ToInt32(Console.ReadLine());
                if(userSelect == 5){
                    endProgram = true;
                }else if(userSelect == 1){
                    gameplay.RunGameplay(gameDifficult, scoreBoard);
                }else if(userSelect == 2){
                    gameDifficult.ChangeDifficult();
                }else if(userSelect == 3){
                    scoreBoard.ShowScoreBoard();
                }else if(userSelect == 4){
                    helpDetail.ShowHelpDetail();
                }
            }while(!endProgram);
        }
        public bool IsObstacle(){
            bool isObstacle = false;
            
            return isObstacle;
        }
    }
}
