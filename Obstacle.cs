using System;
using System.Collections.Generic;

namespace SnakeGame2
{
    public class Obstacle
    {
        private char _char;
        private int _x;
        private int _y;
        private bool _obstacle;
        public Obstacle(char charObstacle){
            _char = charObstacle;
            _obstacle = false;
        }
        public void DrawObstacle(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(_x, _y);
            Console.Write(_char);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void GenerateObstacle(List<int> snakeX, List<int> snakeY, int foodX, int foodY){
            bool generateObstacleX = false;
            bool generateObstacleY = false;
            Random rd = new Random();
            do{
                int obstacleX = rd.Next(1, 80);
                bool repeatX = false;
                if(obstacleX == foodX){
                    repeatX = true;
                }
                for(int bodyX =  0; bodyX < snakeX.Count; bodyX++){
                    if(obstacleX == snakeX[bodyX]){
                        repeatX = true;
                    }
                }
                if(!repeatX){
                    _x = obstacleX;
                    generateObstacleX = true;
                }
            }while(!generateObstacleX);
            do{
                int obstacleY = rd.Next(2, 25);
                bool repeatY = false;
                if(obstacleY == foodY){
                    repeatY = true;
                }
                for(int bodyY =  0; bodyY < snakeY.Count; bodyY++){
                    if(obstacleY == snakeY[bodyY]){
                        repeatY = true;
                    }
                }
                if(!repeatY){
                    _y = obstacleY;
                    generateObstacleY = true;
                }
            }while(!generateObstacleY);
            _obstacle = true;
        }
        public bool IsObstacle(int x, int y){
            bool isObstacle = false;
            if((_x == x) && (_y == y)){
                isObstacle = true;
            }
            return isObstacle;
        }
        public bool ObstacleExist{
            get{ return _obstacle; }
            set{ _obstacle = value; }
        }
        public int ObstacleX{
            get{ return _x; }
        }
        public int ObstacleY{
            get{ return _y; }
        }
    }
}