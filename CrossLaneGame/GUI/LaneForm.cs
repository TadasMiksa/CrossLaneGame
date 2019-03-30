using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.GUI
{
    class LaneForm //draw lanes
    {
        private int X;
        private int Y;
        private int Width;
        private int Height;
        private char _renderChar;
        public LaneForm(int X, int Y, int Width, int Height, char _renderChar)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
            this._renderChar = _renderChar;
        }
        public void Render()
        {
            for (int i = 0; i <Height; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0 || i == Height - 1 || j == 0 || j == Width - 1)
                    {
                        Console.Write(_renderChar);
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
            }
        }

    }
}
