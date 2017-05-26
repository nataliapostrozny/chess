using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaPostrozny.Figures
{
    class Queen : Figure
    {
        public Queen(Colour colour) : base(colour, "Queen")
        {
            _posX = 'D';
            if(colour == Colour.White)
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
            if(positionX > 'H' || positionX < 'A')
            {
                return false;
            }
            if(positionY > 8 || positionY < 1)
            {
                return false;
            }
            return true;
        }
    }
}
