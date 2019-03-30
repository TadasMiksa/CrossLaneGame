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
        private HeroForm _heroForm;
        public HeroRenderer(HeroForm heroForm)
        {
            _heroForm = heroForm;
        }
        public void RenderHero()
        {
            Console.SetCursorPosition(_heroForm.XPosition, _heroForm.YPosition);
            Console.Write(_heroForm.RenderChar);
        }
    }
}
