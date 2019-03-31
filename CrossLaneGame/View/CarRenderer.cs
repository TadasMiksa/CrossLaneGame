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
     
        private List<CarForm> _listOfCarForms = new List<CarForm>();
        public CarRenderer(List<CarForm> carforms)
        {
            _listOfCarForms = carforms;
        }
        public void RenderCar()
        {
            foreach (CarForm item in _listOfCarForms)
            {
                for (int i = 0; i < item.CarLenght; i++)
                {
                    Console.SetCursorPosition(item.XPosition + i, item.YPosition);
                    Console.Write(item.RenderChar);
                }
            }


        }


    }
}
