using CrossLaneGame.DataObjects;
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
        private Position _startingPosition;
        private LaneRenderer _showLanes;
        private Hero _hero;
        private HeroForm _heroForm;
        private HeroRenderer _heroRenderer;

        public GamePlayScreen(int x, int y, int width, int height, char renderChar)
        {
            _frame = new Frame(x, y, width, height, renderChar);
            _hero = new Hero(_startingPosition = new Position(_heroStartingXPosition, _heroStartingYPosition));
            _heroForm = new HeroForm(_hero, '@');
            _heroRenderer = new HeroRenderer(_heroForm);
            _showLanes = new LaneRenderer();
        }

        public int HeroCoordinatesX => _hero.Position.XPosition;
        public int HeroCoordinatesY => _hero.Position.YPosition;

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
            _heroRenderer.RenderHero();
        }
    }
}
