using System;

namespace SnakeGame2
{
    public class Gameplay
    {
        public Gameplay(){

        }
        public void RunGameplay(GameDifficult gameDifficult, ScoreBoard scoreBoard){
            Console.Clear();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Map map = new Map();
            map.DrawMap();
            ConsoleKey keyPress;
            bool endGame = false;
            Snake snake = new Snake('*');
            snake.DefaultSnake();
            Food food = new Food('^', 'S', 'G');
            int foodCount = 0;
            int endfoodCount = 150;
            int specialFoodCount = 0;
            int endspecialFoodCount = 150;
            int godFoodCount = 0;
            int endgodFoodCount = 150;
            bool godMode = false;
            int godModeCount = 0;
            int endgodModeCount = 100;
            Obstacle obstacle = new Obstacle('#');
            int obstacleCount = 0;
            int endObstacleCount  = 100;
            if(gameDifficult.Difficult == 1){
                endfoodCount = 200;
                endspecialFoodCount = 200;
                endgodFoodCount = 200;
                endObstacleCount  = 150;
                endgodModeCount = 150;
            }else if(gameDifficult.Difficult == 2){
                endfoodCount = 150;
                endspecialFoodCount = 150;
                endgodFoodCount = 150;
                endObstacleCount  = 100;
                endgodModeCount = 100;
            }else if(gameDifficult.Difficult == 3){
                endfoodCount = 100;
                endspecialFoodCount = 100;
                endgodFoodCount = 100;
                endObstacleCount  = 50;
                endgodModeCount = 50;
            }
            do{
                Console.SetCursorPosition(1, 0);
                Console.Write($"Move: Arrow Key   Quit: Esc   Score: {snake.SnakeX.Count - 3}   Life: {snake.Life}");
                if(!food.FoodExist){
                    food.GenerateFood(snake.SnakeX, snake.SnakeY);
                    food.DrawFood();
                    foodCount = 0;
                }
                if(!food.SpecialFoodExist){
                    food.GenerateSpecialFood(snake.SnakeX, snake.SnakeY);
                    food.DrawSpecialFood();
                    specialFoodCount = 0;
                }
                if(!food.GodFoodExist){
                    food.GenerateGodFood(snake.SnakeX, snake.SnakeY);
                    food.DrawGodFood();
                    godFoodCount = 0;
                }
                if(!obstacle.ObstacleExist){
                    obstacle.GenerateObstacle(snake.SnakeX, snake.SnakeY, food.FoodX, food.FoodY);
                    obstacle.DrawObstacle();
                    obstacleCount = 0;
                }
                if(!godMode){
                    if(obstacle.IsObstacle(snake.SnakeHeadX, snake.SnakeHeadY)){
                        obstacle.ObstacleExist = false;
                        snake.Life -= 1;
                        if(snake.Life == 0){
                            break;
                        }
                    }
                }
                if(food.IsFood(snake.SnakeHeadX, snake.SnakeHeadY)){
                    food.FoodExist = false;
                    snake.SnakeGrow(food.FoodX, food.FoodY);
                }
                if(food.IsSpecialFood(snake.SnakeHeadX, snake.SnakeHeadY)){
                    food.SpecialFoodExist = false;
                    snake.Life += 1;
                }
                if(food.IsGodFood(snake.SnakeHeadX, snake.SnakeHeadY)){
                    food.GodFoodExist = false;
                    godMode = true;
                    godModeCount = 0;
                }
                if(godMode == true){
                    if(godModeCount == endgodModeCount){
                        godMode = false;
                        godModeCount = 0;
                    }
                }
                if(!godMode){
                    snake.DrawSnake(ConsoleColor.Green);
                }else{
                    snake.DrawSnake(ConsoleColor.Cyan);
                }
                if(foodCount == endfoodCount){
                    food.FoodExist = false;
                    Console.SetCursorPosition(food.FoodX, food.FoodY);
                    Console.Write(' ');
                    foodCount = 0;
                }
                if(specialFoodCount == endspecialFoodCount){
                    food.SpecialFoodExist = false;
                    Console.SetCursorPosition(food.SpecialFoodX, food.SpecialFoodY);
                    Console.Write(' ');
                    specialFoodCount = 0;
                }
                if(godFoodCount == endgodFoodCount){
                    food.GodFoodExist = false;
                    Console.SetCursorPosition(food.GodFoodX, food.GodFoodY);
                    Console.Write(' ');
                    godFoodCount = 0;
                }
                if(obstacleCount == endObstacleCount){
                    obstacle.ObstacleExist = false;
                    Console.SetCursorPosition(obstacle.ObstacleX, obstacle.ObstacleY);
                    Console.Write(' ');
                    obstacleCount = 0;
                }
                if(Console.KeyAvailable){
                    keyPress = Console.ReadKey().Key;
                    if(keyPress == ConsoleKey.Escape){
                        endGame = true;
                    }else if(keyPress == ConsoleKey.UpArrow){
                        if(snake.DY != 1){
                            snake.Move(0, -1);
                        }
                    }else if(keyPress == ConsoleKey.DownArrow){
                        if(snake.DY != -1){
                            snake.Move(0, 1);
                        }
                    }else if(keyPress == ConsoleKey.LeftArrow){
                        if(snake.DX != 1){
                            snake.Move(-1, 0);
                        }
                    }else if(keyPress == ConsoleKey.RightArrow){
                        if(snake.DX != -1){
                            snake.Move(1, 0);
                        }
                    }
                }
                foodCount += 1;
                specialFoodCount += 1;
                godFoodCount += 1;
                if(godMode == true){
                    godModeCount += 1;
                }
                obstacleCount += 1;
                System.Threading.Thread.Sleep(50);
            }while(!endGame);
            scoreBoard.RecordScore(snake.SnakeX);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 12);
            Console.WriteLine($"Score: {snake.SnakeX.Count - 3}");
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}