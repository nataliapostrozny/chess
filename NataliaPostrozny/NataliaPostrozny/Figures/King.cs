using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaPostrozny.Figures
{
    class King : Figure
    {
        public King(Colour colour) : base(colour, "King")
        {
            _posX = 'E';
            if (colour == Colour.White)
            {
                _posY = 1;
            }
            else
            {
                _posY = 8;
            }
        }

        protected override bool canMove(char positionX, int positionY)
        {
            if (Math.Abs((int)positionX - (int)_posX) > 1)
            {
                return false;
            }

            if (Math.Abs(positionY - _posY) > 1)
            {
                return false;
            }

            return true;
        }
    }
}
