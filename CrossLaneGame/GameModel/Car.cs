using CrossLaneGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GameModel
{
    class Car //Enemy data (speed,x,id)
    {
        private Random rnd = new Random();
        private int _speed;
        private int _x;
        private int _y;
        private int _width; //cars lenght

        public Car(int speed, int x, int y, int width = 4)
        {
            _speed = speed;
            _x = x;
            _y = y;
            _width = width;
        }
        public int GetCarLenght()
        {
            return _width;
        }
        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }

        public void MoveCarRight()
        {
            _x++;
        }
        public void MoveCarLeft()
        {
            _x--;

        }
        public float ChangeSpeed(int giveSpeed) //???
        {
            float tempSpeed = giveSpeed / rnd.Next(1, 3);
            //  _speed = tempSpeed + _x;
            return _speed;
        }

    }
}
