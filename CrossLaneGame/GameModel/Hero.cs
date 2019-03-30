using CrossLaneGame.DataObjects;
using CrossLaneGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GameModel
{
    class Hero  //hero data (x,y) 
    {
        public Hero(Position position)
        {
            Position = position;
        }

        public Position Position { get; private set; }

        public void MoveRight()
        {
            Position.XPosition++;
        }

        public void MoveLeft()
        {
            Position.XPosition--;
        }

        public void MoveUp(int points)
        {
            Position.YPosition = Position.YPosition - points;
        }

        public void MoveDown(int points)
        {
            Position.YPosition = Position.YPosition + points;
        }
    }
}
