using CrossLaneGame.GameController;
using CrossLaneGame.GameModel;
using CrossLaneGame.GUI;
using CrossLaneGame.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.Screens
{
    class GamePlayScreen
    {
        private int _heroStartingXPosition = 20;
        private int _heroStartingYPosition = 9;

        private Frame _frame;

        private HeroRenderer _showHero;
        private LaneRenderer _showLanes;
        private CarRenderer _showCars;

        private Lanes _lanesOfCars;

        private Hero _hero;
        private Car _car;

        private List<Car> _someCars = new List<Car>();

        public GamePlayScreen(int x, int y, int width, int height, char renderChar)
        {
            _frame = new Frame(x, y, width, height, renderChar);

            _hero = new Hero(_heroStartingXPosition,_heroStartingYPosition);

         

          
            _showLanes = new LaneRenderer();
   
           
            _lanesOfCars = new Lanes(_car);
            
        }

        public int HeroCoordinatesX => _hero.X;
        public int HeroCoordinatesY => _hero.Y;

    //    public void MoveEnemyCarToLeft()
    //    {
    //        foreach (Car _enemyCar in _someCars)
    //        {
    //            if (_enemyCar.GetX() > 1)
    //            {    
    //                _enemyCar.MoveCarLeft();               
    //            }
    //        }
    //    }

        public void MoveHeroLeft()
        {
            if (_hero.X > 1)
            {
                _hero.MoveLeft();
            }
        }

        public void MoveHeroRight()
        {
            if (_hero.X < 38)
            {
                _hero.MoveRight();
            }
        }

        public void MoveHeroUp()
        {
            if (_hero.Y > 1)
            {
                _hero.MoveUp(2);
            }
        }

        public void MoveHeroDown()
        {
            if (_hero.Y < 9)
            {
                _hero.MoveDown(2);
            }
        }

        public void Render()
        {
            _showLanes.RenderLanes();
            _frame.Render();
            _showHero.RenderHero();
         //   _showCars.RenderCar();

        }
    }
}
