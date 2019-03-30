﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.DataObjects
{
    class Position
    {
        public Position(int xPosition, int yPosition)
        {
            XPosition = xPosition;
            YPosition = yPosition;
        }

        public int XPosition { get; set; }
        public int YPosition { get; set; }
    }
}
