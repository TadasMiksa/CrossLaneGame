using CrossLaneGame.GameModel;
using CrossLaneGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.View
{
    class HeroRenderer //hero rendering
    {
        private Hero _hero;
        private HeroForm _heroForm;
        public HeroRenderer(Hero hero)
        {
            _hero = hero;
        }
        public void RenderHero()
        {
            _heroForm = new HeroForm(_hero.GetX(),_hero.GetY(), '@');
            _heroForm.Render();
        }
    }
}
