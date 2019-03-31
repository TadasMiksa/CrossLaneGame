using CrossLaneGame.GameController;
using CrossLaneGame.GameModel;
using CrossLaneGame.GUI;
using CrossLaneGame.Screens;
using CrossLaneGame.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

class GamePlayController
{
    private GamePlayScreen _gps;

    public GamePlayController()
    {
        Random rnd = new Random();
        _gps = new GamePlayScreen(0, 0, 39, 10, '#');
    }
    public void StartGameLoop()
    {
        _gps.Timing();
        bool collision = false;
        do
        { 
            _gps.MoveAllCars();
            Console.Clear();
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.LeftArrow:
                        _gps.MoveHeroLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        _gps.MoveHeroRight();
                        break;
                    case ConsoleKey.UpArrow:
                        _gps.MoveHeroUp();
                        break;
                    case ConsoleKey.DownArrow:
                        _gps.MoveHeroDown();
                        break;
                }
            }
             if (_gps.CollisionDetection() == true)
            {
                collision = true;
            }
        
            _gps.Render();

            System.Threading.Thread.Sleep(250);
        } while (collision == false);

        Console.Clear();
        _gps.GameOver();
    }
}
