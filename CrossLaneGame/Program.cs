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
            GamePlayController gpc = new GamePlayController();
            gpc.StartGameLoop();
            Console.ReadKey();
            
        }
    }
}
