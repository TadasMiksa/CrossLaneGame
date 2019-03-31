using CrossLaneGame.GameModel;
using CrossLaneGame.GUI;
using CrossLaneGame.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            GuiController game = new GuiController();
            game.ShowMenu();

            Console.ReadKey();

        }
    }
}
