using CrossLaneGame.GameModel;
using CrossLaneGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.View
{
    class CarRenderer //enemy rendering
    {
        //lane nr + list of cars
        private CarForm _carForm;
        private int _laneNr;
        private List<Car> _listOfCars = new List<Car>();
        public CarRenderer(int laneNr, List<Car> listOfCars)
        {
           _laneNr = laneNr;
            _listOfCars = listOfCars;
            _carForm = new CarForm(_listOfCars[laneNr]);
        }


        public void Render()
        {
            for (int i = 0; i < _carForm.CarLenght; i++)
            {
                Console.Write(_carForm.RenderChar);
            }
        }


    }
}
