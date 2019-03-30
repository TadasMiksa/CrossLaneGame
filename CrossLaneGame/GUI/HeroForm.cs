using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GUI
{
    class HeroForm 
    {
        
        private char _renderChar;
        private int _x;
        private int _y;
        public HeroForm (int x,int y,char renderChar)
        {
            _x = x;
            _y = y;
            _renderChar = renderChar;
        }
        
        public void Render()
        {
            Console.SetCursorPosition(_x,_y);
            Console.Write(_renderChar);
        }
    }
}
