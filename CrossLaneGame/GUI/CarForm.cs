using CrossLaneGame.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GUI
{
    class CarForm //draw a car
    {
        private Car _carData;
        private char _renderChar;

        public CarForm(Car car, char renderChar = 'O')
        {
            _carData = car;
            _renderChar = renderChar;
        }

        public void Render()
        {
            for (int i = 0; i < _carData.GetCarLenght(); i++)
            {
                Console.Write(_renderChar);
            }
        }

   
    }
}
