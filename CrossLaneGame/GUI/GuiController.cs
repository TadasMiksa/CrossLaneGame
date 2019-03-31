using CrossLaneGame.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GUI
{
    class GuiController
    {
        private MenuScreen _gameWind;
        private GamePlayController _gamePlay;
        private GameOverScreen _gameOver;
        public GuiController()
        {
            _gameWind = new MenuScreen();
            _gamePlay = new GamePlayController();
            _gameOver = new GameOverScreen();
        }
        public void ShowGameOver()
        {
            _gameOver.Render();
            bool needToRender = false;
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Q:
                            _gameOver.ShowQuitButton();
                            break;
                        case ConsoleKey.P:
                            _gameOver.ShowPlayButton();
                            break;
                        case ConsoleKey.Enter:
                            if (_gameOver.EnterPressing() == 0)
                            {
                                Console.Clear();
                                _gamePlay.StartGameLoop();
                            }
                            else if (_gameOver.EnterPressing() == 1)
                            {
                                Environment.Exit(0);

                            }
                            break;
                    }
                }
            } while (needToRender == false);
        }
  
        public void ShowMenu()
        {
            bool needToRender = false;

            _gameWind.Render();
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Q:
                            _gameWind.ShowQuitButton();
                            break;
                        case ConsoleKey.P:
                            _gameWind.ShowPlayButton();
                            break;
                        case ConsoleKey.Enter:
                            if (_gameWind.EnterPressing() == 0)
                            {
                                Console.Clear();
                                _gamePlay.StartGameLoop();
                            }
                            else if (_gameWind.EnterPressing() == 1)
                            {
                                Environment.Exit(0);

                            }
                            break;
                    }
                }
            } while (needToRender == false);
        }
    }
}

