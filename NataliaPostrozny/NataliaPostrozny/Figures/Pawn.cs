using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaPostrozny.Figures
{
    class Pawn : Figure
    {
        public Pawn(Colour colour, int number) : base(colour, "Pawn" + number.ToString())
        {
            if (colour == Colour.White)
            {
                int tmp = (int)'A';
                tmp = tmp + number - 1;
                _posX = (char)tmp;

                _posY = 2;
                
            }
            else
            {
                int tmp = (int)'H';
                tmp = tmp - number + 1;
                _posX = (char)tmp;

                _posY = 7;
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

            if ((Math.Abs((int)positionX - (int)_posX) > 1)){
                return false;
            }

            if(colour == Colour.White)
            {
                if((positionY - _posY) != 1)
                {
                    return false;
                }
            }
            else
            {
                if ((positionY - _posY) != -1)
                {
                    return false;
                }
            }


            return true;

        }
    }
}
