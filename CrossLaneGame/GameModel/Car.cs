using CrossLaneGame.DataObjects;
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

        public Car(Position position,  int speed, int width = 4)
        {
            _speed = speed;
            Position = position;
            Width = width;
        }

        public Position Position { get; private set; }

        public int Width { get; } //get car lenght

        public void Move(Direction direction)
        {
            if (Position.XPosition == Limits.XMinLimit)
            {
                Position.XPosition = Limits.XMaxLimit;
            }
            else
            {
                if (direction == Direction.Left)
                {
                    Position.XPosition--;
                }
                else if (direction == Direction.Right)
                {
                    Position.XPosition++;
                }
            }
        }

        public float ChangeSpeed(int giveSpeed) //???
        {
            float tempSpeed = giveSpeed / rnd.Next(1, 3);
            //  _speed = tempSpeed + _x;
            return _speed;
        }

    }
}
