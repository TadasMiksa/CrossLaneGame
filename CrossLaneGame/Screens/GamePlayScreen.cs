using CrossLaneGame.DataObjects;
using CrossLaneGame.GameController;
using CrossLaneGame.GameModel;
using CrossLaneGame.GUI;
using CrossLaneGame.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrossLaneGame.Screens
{
    class GamePlayScreen
    {
        private int _enemyId = 1;
        private int _heroStartingXPosition = 20;
        private int _heroStartingYPosition = 9;
        private int _startingLevelNumber = 1;
        private Frame _frame;
        private Position _startingPosition;
        private Lane _lane;
        private LaneRenderer _showLanes;

        private Car _car;
        private Car _car2;
        private Cars _cars;

        private CarForm _carForm;
        private CarForm _carForm2;
        private CarRenderer _showCar;

        private Hero _hero;
        private HeroForm _heroForm;
        private HeroRenderer _heroRenderer;
        private List<Car> _listOfCars = new List<Car>();
        private List<CarForm> _listOfForms = new List<CarForm>();
        private Random _rnd;

        public GamePlayScreen(int x, int y, int width, int height, char renderChar)
        {
            _rnd = new Random();

            _cars = new Cars(_listOfCars);

            _showCar = new CarRenderer(_listOfForms);

            _lane = new Lane(_startingLevelNumber, _cars, Direction.Left);

            _hero = new Hero(_startingPosition = new Position(_heroStartingXPosition, _heroStartingYPosition));
            _heroForm = new HeroForm(_hero, '@');
            _heroRenderer = new HeroRenderer(_heroForm);

            _showLanes = new LaneRenderer();
            _frame = new Frame(x, y, width, height, renderChar);

        }

        public int HeroCoordinatesX => _hero.Position.XPosition;
        public int HeroCoordinatesY => _hero.Position.YPosition;
        public int CarPositionX => _car.Position.XPosition;
        public int CarPositionY => _car.Position.YPosition;
        public int CarLenght => _car.Width;


        public bool CollisionDetection()
        {
            bool Collision = false;
            foreach (Position position in _cars.GetPositions())
            {
                if (_hero.Position.YPosition == position.YPosition)
                {
                    int tempint = CarLenght + position.XPosition;
                    if (_hero.Position.XPosition >= position.XPosition && _hero.Position.XPosition <= tempint)
                    {
                        return Collision = true;
                    }
                }

            }
 
            return Collision;
        }
        public void Timing()
        {
            int nr = 0;
            do
            {
                Timer t = new Timer(TimerCallback, null, 0, 4000);
                for (int i = 0; i <= 3; i++)
                {
                    nr = i;
                }
            } while (nr != 3);
          
        }
        private void TimerCallback(object o)
        {
            for (int i = 3; i < 8; i = i + 2)
            {
                _listOfCars.Add(_car = new Car(_startingPosition = new Position(_rnd.Next(30,38), i), 0, _enemyId));
                _carForm = new CarForm(_car);
                _listOfForms.Add(_carForm);
                _enemyId++;
            }
        }

        public void MoveAllCars()
        {
            _cars.MoveCars(Direction.Left);
        }

        public void MoveHeroLeft()
        {
            if (HeroCoordinatesX > 1)
            {
                _hero.MoveLeft();
            }
        }

        public void MoveHeroRight()
        {
            if (HeroCoordinatesX < 38)
            {
                _hero.MoveRight();
            }
        }

        public void MoveHeroUp()
        {
            if (_hero.Position.YPosition > 1)
            {
                _hero.MoveUp(2);
            }
        }

        public void MoveHeroDown()
        {
            if (_hero.Position.YPosition < 9)
            {
                _hero.MoveDown(2);
            }
        }

        public void Render()
        {

            _showLanes.RenderLanes();
            _frame.Render();

            _showCar.RenderCar();
            _heroRenderer.RenderHero();

        }
        public void GameOver()
        {
            GuiController guiController = new GuiController();
            guiController.ShowGameOver();
        }
    }
}
