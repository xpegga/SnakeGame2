using System;

namespace SnakeGame2
{
    public class Map
    {
        public Map(){

        }
        public void DrawMap(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int drawY = 0; drawY < 27; drawY++){
                Console.SetCursorPosition(0, drawY);
                Console.Write('|');
                Console.SetCursorPosition(82, drawY);
                Console.Write('|');
            }
            for(int drawX = 1; drawX < 82; drawX++){
                Console.SetCursorPosition(drawX, 1);
                Console.Write('=');
                Console.SetCursorPosition(drawX, 26);
                Console.Write('=');
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}