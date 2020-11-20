using System;
using System.Collections.Generic;

namespace SnakeGame2
{
    public class Snake
    {
        char _char;
        private List<int> _snakeX;
        private List<int> _snakeY;
        private int _dx;
        private int _dy;
        private int _life;
        public Snake(char charSnake){
            _char = charSnake;
            _dx = 1;
            _dy = 0;
            _snakeX = new List<int>();
            _snakeY = new List<int>();
            _life = 1;
        }

        public void DefaultSnake(){
            for(int bodyX = 1; bodyX < 4; bodyX++){
                _snakeX.Add(bodyX);
            }
            for(int bodyY = 1; bodyY < 4; bodyY++){
                _snakeY.Add(2);
            }
        }

        public int DX{
            get{ return _dx; }
        }

        public int DY{
            get{ return _dy; }
        }

        public List<int> SnakeX{
            get{ return _snakeX; }
        }

        public List<int> SnakeY{
            get{ return _snakeY; }
        }

        public int SnakeHeadX{
            get{ return _snakeX[0]; }
        }

        public int SnakeHeadY{
            get{ return _snakeY[0]; }
        }

        public int Life{
            get{ return _life; }
            set{ _life = value; }
        }

        public void Move(int dx, int dy){
            _dx = dx;
            _dy = dy;
        }

        public void DrawSnake(ConsoleColor color){
            Console.ForegroundColor = color;
            int currentX;
            int currentY;
            int nextX = _snakeX[0];
            int nextY = _snakeY[0];
            _snakeX[0] = _snakeX[0] + _dx;
            if(_snakeX[0] > 80){
                _snakeX[0] = 1;
            }
            if(_snakeX[0] < 1){
                _snakeX[0] = 80;
            }
            _snakeY[0] = _snakeY[0] + _dy;
            if(_snakeY[0] > 25){
                _snakeY[0] = 2;
            }
            if(_snakeY[0] < 2){
                _snakeY[0] = 25;
            }
            Console.SetCursorPosition(_snakeX[0], _snakeY[0]);
            Console.Write(_char);
            int clearX = _snakeX[0] - _dx;
            int clearY = _snakeY[0] - _dy;
            if(_dx > 0){
                if(clearX < 1){
                    clearX = 80;
                }
            }else{
                if(clearX > 80){
                    clearX = 1;
                }
            }
            if(_dy > 0){
                if(clearY < 2){
                    clearY = 25;
                }
            }else{
                if(clearY > 25){
                    clearY = 2;
                }
            }
            Console.SetCursorPosition(clearX, clearY);
            Console.Write(' ');
            for(int dsnake = 1; dsnake < _snakeX.Count; dsnake++){
                currentX = _snakeX[dsnake];
                currentY = _snakeY[dsnake];
                _snakeX[dsnake] = nextX;
                _snakeY[dsnake] = nextY;
                nextX = currentX;
                nextY = currentY;
                Console.SetCursorPosition(_snakeX[dsnake], _snakeY[dsnake]);
                Console.Write(_char);
                Console.SetCursorPosition(currentX, currentY);
                Console.Write(' ');
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void SnakeGrow(int x, int y){
            _snakeX.Insert(0, x);
            _snakeY.Insert(0, y);
        }
    }
}