using System;

namespace SnakeGame2
{
    public class GameDifficult
    {
        private int _diffcult;
        public GameDifficult(){
            _diffcult = 2;
        }
        public int Difficult{
            get{ return _diffcult; }
        }

        public void ChangeDifficult(){
            bool endChangeDifficult = false;
            int userSelect;
            do{
                Console.Clear();
                Console.WriteLine("### Change Game Difficult ###");
                string currentDifficult;
                if(_diffcult == 1){
                    currentDifficult = "Easy";
                }else if(_diffcult == 2){
                    currentDifficult = "Normal";
                }else if(_diffcult == 3){
                    currentDifficult = "Hard";
                }
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Normal");
                Console.WriteLine("3. Hard");
                Console.WriteLine("Please type the number of difficult you want");
                userSelect = Convert.ToInt32(Console.ReadLine());
                if((userSelect > 0) && (userSelect < 4)){
                    _diffcult = userSelect;
                    endChangeDifficult = true;
                    Console.WriteLine("Change difficult succesful");
                    System.Threading.Thread.Sleep(250);
                }
            }while(!endChangeDifficult);
        }
    }
}