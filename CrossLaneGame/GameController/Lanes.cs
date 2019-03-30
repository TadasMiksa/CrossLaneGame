using CrossLaneGame.GameModel;
using CrossLaneGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GameController
{
    class Lanes // sito galimai nereikia
    {
        private Car _car;      
        private List<List<Car>> _laneOfCars = new List<List<Car>>();
        public Lanes(Car car)
        {
            _car = car;
        }
        public void AddCarOnLane(int laneNr)
        {
            _laneOfCars[laneNr].Add(_car);
        }
        public List<Car> GetLaneCars(int laneNr)
        {
            return _laneOfCars[laneNr];
        }
       

    }
}
