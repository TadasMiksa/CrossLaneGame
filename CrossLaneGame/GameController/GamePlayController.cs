using CrossLaneGame.GameController;
using CrossLaneGame.GameModel;
using CrossLaneGame.GUI;
using CrossLaneGame.Screens;
using CrossLaneGame.View;
using System;
using System.Collections.Generic;
using System.Text;


class GamePlayController
{
    private GamePlayScreen _gps;


    public GamePlayController()
    {

        InitGame();
    }

    public void InitGame()
    {
     
        Random rnd = new Random();
        _gps = new GamePlayScreen(0, 0, 39, 10, '#');

    }

    public void StartGameLoop()
    {
        bool collision = false;

        do
        {
            Console.Clear();

            _gps.MoveEnemyCarToLeft();

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
        
         //   if (_gps.HeroCoordinatesX() >= _lanesWithCars.GetLaneCars(x) && _gps.HeroCoordinatesX() <= _lanesWithCars.GetLaneCars(x)+_car.GetCarLenght())
         //       collision = true;
         //   }

            _gps.Render();
   
            System.Threading.Thread.Sleep(250);
        } while (collision == false);

        Console.Clear();
        Console.WriteLine("GAME OVER");

    }
    //  public void StartGame()
    //  {
    //      StartGameLoop();
    //  }
}
