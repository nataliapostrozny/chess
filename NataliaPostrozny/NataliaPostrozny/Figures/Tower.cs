using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaPostrozny.Figures
{
    class Tower : Figure
    {
        public Tower(Colour colour, int numberOfTower) : base(colour, "Tower"+numberOfTower.ToString())
        {
            if(numberOfTower == 1)
            {
                _posX = 'A';
            }
            else
            {
                _posX = 'H';
            }
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
            if (positionX > 'H' || positionX < 'A')
            {
                return false;
            }
            if (positionY > 8 || positionY < 1)
            {
                return false;
            }


            if ((Math.Abs((int)positionX - _posX) == 0) && (Math.Abs(positionY - _posY) > 1))
            {
                return true;
            }
            if ((Math.Abs((int)positionX - _posX) > 1) && (Math.Abs(positionY - _posY) == 0))
            {
                return true;
            }

            return false;
        }
    }
}
