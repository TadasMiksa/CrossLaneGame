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
        private List<Car> _cars;
        public CarForm
            (List<Car> cars, char renderChar = 'O')
        {
            _cars = cars;
            RenderChar = renderChar;
        }

        public CarForm(Car car, char renderChar = 'O')
        {
            _carData = car;
            RenderChar = renderChar;

        }

        public char RenderChar { get; set; }

        public int CarLenght => _carData.Width;

        public int XPosition => _carData.Position.XPosition;

        public int YPosition => _carData.Position.YPosition;
        //    public int CarLenght2()
        //    {
        //        foreach (Car car in _cars)
        //        {
        //            return car.Width;
        //        }
        //        return 0;
        //    }
        //    public int XPosition()
        //    {
        //        foreach (Car car in _cars)
        //        {
        //            return car.Position.XPosition;
        //        }
        //        return 0;
        //    }
        //    public int YPosition()
        //    {
        //        foreach (Car car in _cars)
        //        {
        //            return car.Position.YPosition;
        //        }
        //        return 0;
        //    }


    }
}

