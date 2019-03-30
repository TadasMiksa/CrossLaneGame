using CrossLaneGame.DataObjects;
using CrossLaneGame.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GameController
{
    class Cars
    {
        private List<Car> _listOfCars = new List<Car>();
       
        public Cars(List<Car> listOfCars)
        {
            _listOfCars = listOfCars;
        }

        public List<Position> GetPositions()
        {
            List<Position> temp = new List<Position>();
            foreach (Car car in _listOfCars)
            {
                temp.Add(car.Position);  
            }
            return temp;
        }

        public void MoveCars(Direction direction)
        {
            foreach (Car car in _listOfCars)
            {
                car.Move(direction);
            }
        }
    }
}
