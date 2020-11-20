using System;
using System.Collections.Generic;

namespace SnakeGame2
{
    public class Food
    {
        private char _char;
        private int _x;
        private int _y;
        private bool _food;
        private char _specialchar;
        private int _specialx;
        private int _specialy;
        private bool _specialfood;
        private char _godchar;
        private int _godx;
        private int _gody;
        private bool _godFood;
        public Food(char charFood, char charSpecialFood, char charGod){
            _char = charFood;
            _food = false;
            _specialchar = charSpecialFood;
            _specialfood = false;
            _godchar = charGod;
            _godFood = false;
        }
        public void DrawFood(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(_x, _y);
            Console.Write(_char);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public bool IsFood(int x, int y){
            bool isFood = false;
            if((x == _x) && (y == _y)){
                isFood = true;
            }
            return isFood;
        }

        public void GenerateFood(List<int> snakeX, List<int> snakeY){
            bool generateFoodX = false;
            bool generateFoodY = false;
            Random rd = new Random();
            do{
                int foodX = rd.Next(1, 80);
                bool repeatX = false;
                for(int bodyX =  0; bodyX < snakeX.Count; bodyX++){
                    if(foodX == snakeX[bodyX]){
                        repeatX = true;
                    }
                }
                if(!repeatX){
                    _x = foodX;
                    generateFoodX = true;
                }
            }while(!generateFoodX);
            do{
                int foodY = rd.Next(2, 25);
                bool repeatY = false;
                for(int bodyY =  0; bodyY < snakeY.Count; bodyY++){
                    if(foodY == snakeY[bodyY]){
                        repeatY = true;
                    }
                }
                if(!repeatY){
                    _y = foodY;
                    generateFoodY = true;
                }
            }while(!generateFoodY);
            _food = true;
        }

        public void DrawSpecialFood(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(_specialx, _specialy);
            Console.Write(_specialchar);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public bool IsSpecialFood(int x, int y){
            bool isSpecialFood = false;
            if((x == _specialx) && (y == _specialy)){
                isSpecialFood = true;
            }
            return isSpecialFood;
        }
        public void GenerateSpecialFood(List<int> snakeX, List<int> snakeY){
            bool generateSpecialFoodX = false;
            bool generateSpecialFoodY = false;
            Random rd = new Random();
            do{
                int specialFoodX = rd.Next(1, 80);
                bool repeatX = false;
                if(specialFoodX == _x){
                    repeatX = true;
                }
                for(int bodyX =  0; bodyX < snakeX.Count; bodyX++){
                    if(specialFoodX == snakeX[bodyX]){
                        repeatX = true;
                    }
                }
                if(!repeatX){
                    _specialx = specialFoodX;
                    generateSpecialFoodX = true;
                }
            }while(!generateSpecialFoodX);
            do{
                int specialFoodY = rd.Next(2, 25);
                bool repeatY = false;
                if(specialFoodY == _y){
                    repeatY = true;
                }
                for(int bodyY =  0; bodyY < snakeY.Count; bodyY++){
                    if(specialFoodY == snakeY[bodyY]){
                        repeatY = true;
                    }
                }
                if(!repeatY){
                    _specialy = specialFoodY;
                    generateSpecialFoodY = true;
                }
            }while(!generateSpecialFoodY);
            _specialfood = true;
        }

        public void DrawGodFood(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(_godx, _gody);
            Console.Write(_godchar);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public bool IsGodFood(int x, int y){
            bool isGodFood = false;
            if((x == _godx) && (y == _gody)){
                isGodFood = true;
            }
            return isGodFood;
        }

        public void GenerateGodFood(List<int> snakeX, List<int> snakeY){
            bool generateGodFoodX = false;
            bool generateGodFoodY = false;
            Random rd = new Random();
            do{
                int godFoodX = rd.Next(1, 80);
                bool repeatX = false;
                if((godFoodX == _x) || (godFoodX == _specialx)){
                    repeatX = true;
                }
                for(int bodyX =  0; bodyX < snakeX.Count; bodyX++){
                    if(godFoodX == snakeX[bodyX]){
                        repeatX = true;
                    }
                }
                if(!repeatX){
                    _godx = godFoodX;
                    generateGodFoodX = true;
                }
            }while(!generateGodFoodX);
            do{
                int godFoodY = rd.Next(2, 25);
                bool repeatY = false;
                if((godFoodY == _x) || (godFoodY == _specialy)){
                    repeatY = true;
                }
                for(int bodyY =  0; bodyY < snakeY.Count; bodyY++){
                    if(godFoodY == snakeY[bodyY]){
                        repeatY = true;
                    }
                }
                if(!repeatY){
                    _gody = godFoodY;
                    generateGodFoodY = true;
                }
            }while(!generateGodFoodY);
            _godFood = true;
        }

        public bool FoodExist{
            get{ return _food; }
            set{ _food = value; }
        }

        public int FoodX{
            get{ return _x; }
        }
        
        public int FoodY{
            get{ return _y; }
        }

        public bool SpecialFoodExist{
            get{ return _specialfood; }
            set{ _specialfood = value; }
        }

        public int SpecialFoodX{
            get{ return _specialx; }
        }
        public int SpecialFoodY{
            get{ return _specialy; }
        }

        public bool GodFoodExist{
            get{ return _godFood; }
            set{ _godFood = value; }
        }

        public int GodFoodX{
            get{ return _godx; }
        }
        public int GodFoodY{
            get{ return _gody; }
        }
    }
}