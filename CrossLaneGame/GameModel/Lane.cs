using CrossLaneGame.DataObjects;
using CrossLaneGame.GameController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GameModel
{
    class Lane 
    {
        private int _levelNumber;
        private Cars _cars;
        private Direction _direction;

        public Lane(int levelNumber, Cars cars,Direction direction)
        {
            _levelNumber = levelNumber;
            _cars = cars;
            _direction = direction;    
        }
        public void MoveCars()
        {
            _cars.MoveCars(_direction);
        }
        public int ShowLevelNumber()
        {
            return _levelNumber;
        }
    }
}
