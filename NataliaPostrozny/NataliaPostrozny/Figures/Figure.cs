using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaPostrozny.Figures
{

    public enum Colour
    {
        White,
        Black
    };



    abstract class Figure
    {

        public Colour colour { get; private set; }
        public String name { get; private set; }
        protected char _posX;
        protected int _posY;

        public Figure(Colour colour, String name)
        {
            this.colour = colour;
            this.name = colour.ToString() + " " + name;
            onChange += OnPositionChanged; 
        }

        private void OnPositionChanged()
        {
            Console.WriteLine(name + " changed position");
        }

        public String getPosition()
        {
            return _posX + _posY.ToString();
        }
        
        public String toString()
        {
            return "Figure " + name + " is on position " + _posX + " " + _posY.ToString();
        }
        
        public void move(char positionX, int positionY)
		{
			if(canMove(positionX, positionY)){
                _posX = positionX;
                _posY = positionY;
                onChange?.Invoke();
            }
			else {
				Console.WriteLine("Cant move there!");
			}
		}

        abstract protected bool canMove(char positionX, int positionY);

        public delegate void changePositioneHandler();
        public event changePositioneHandler onChange;

    }
}
