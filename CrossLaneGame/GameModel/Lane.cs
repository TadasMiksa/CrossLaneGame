using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GameModel
{
    class Lane //car list<>, int levelNR
    {
        private int _levelNr;
        private Car car;
        private List<Car> _listOfCars = new List<Car>();
        public Lane(int levelNr)
        {
            _levelNr = levelNr;
            _listOfCars.Add(new Car(1,0,0));
        }
        public int ShowLevelNumber()
        {
            return _levelNr;
        }
    }
}
