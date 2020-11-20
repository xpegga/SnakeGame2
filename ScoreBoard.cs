using System;
using System.Collections.Generic;
using System.IO;

namespace SnakeGame2
{
    public class ScoreBoard
    {
        public ScoreBoard(){

        }
        public void ShowScoreBoard(){
            bool endShowScoreBoard = false;
            int userSelect;
            do{
                Console.Clear();
                Console.WriteLine("### Score Board ###");
                string[] allScore = File.ReadAllLines(@".\Score.txt");
                for(int showScore = 0; showScore < 10; showScore++){
                    Console.WriteLine($"Top {showScore + 1}: {allScore[showScore]}");
                }
                Console.WriteLine("Type 11 to exit Score Board");
                userSelect = Convert.ToInt32(Console.ReadLine());
                if(userSelect == 11){
                    endShowScoreBoard = true;
                }
            }while(!endShowScoreBoard);
        }

        public void RecordScore(List<int> SnakeX){
            int currentScore = SnakeX.Count - 3;
            int nextScore;
            string[] allScore = File.ReadAllLines(@".\Score.txt");
            for(int findScoreLoop = 0; findScoreLoop < 10; findScoreLoop++){
                if(currentScore > Convert.ToInt32(allScore[findScoreLoop])){
                    nextScore = Convert.ToInt32(allScore[findScoreLoop]);
                    allScore[findScoreLoop] = currentScore.ToString();
                    currentScore = nextScore;
                }
            }
            File.WriteAllLines(@".\Score.txt", allScore);
        }
    }
}