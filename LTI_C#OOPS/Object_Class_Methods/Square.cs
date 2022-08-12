using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_Class_Methods
{
    class Square
    {
        private double side;

        public override bool Equals(object obj)
        {
            Square sq = (Square)obj;
            if (sq.Side == this.Side)
            {
                return true;
            }
            else
                return false;
            //return base.Equals(obj);
        }
        public override string ToString()
        {
            return side.ToString();
            //return base.ToString();
        }

        public Square()
        {
            side = 1.0;
        }
        public Square(double side)
        {
            this.side = side;
        }

        public double Side
        {
            get { return side; }
            set { side = value; }
        }
    }
}
