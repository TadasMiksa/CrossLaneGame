using CrossLaneGame.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GUI
{
    class HeroForm 
    {
        private readonly Hero _hero;

        public HeroForm (Hero hero,char renderChar)
        {
            _hero = hero;
            RenderChar = renderChar;
        }
        public char RenderChar { get; }

        public int XPosition => _hero.Position.XPosition;

        public int YPosition => _hero.Position.YPosition;

        public void MoveUp(int points) => _hero.MoveUp(points);

        public void MoveDown(int points) => _hero.MoveDown(points);

        public void MoveLeft() => _hero.MoveLeft();

        public void MoveRight() => _hero.MoveRight();
    }
}
