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
            RenderChar = renderChar;
        }
        public char RenderChar { get; set; }

        public int XPosition => _carData.Position.XPosition;

        public int YPosition => _carData.Position.YPosition;

        public int CarLenght => _carData.Width;


    }
}
