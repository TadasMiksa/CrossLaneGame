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
        private int _x;
        private int _y;

        public Hero (int x, int y)
        {
            _x = x;
            _y = y;
           
        }
        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }
        public void MoveRight()
        {
            _x++;
        }
        public void MoveLeft()
        {
            _x--;
        }
        public void MoveUp(int points)
        {
            _y = _y - points;
        }
        public void MoveDown(int points)
        {
            _y = _y + points;
        }

    }
}
