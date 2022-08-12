using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_Example
{
    class Program
    {
        class Cpoint
        {
            int x, y;
            //No Argument Constructor
            public Cpoint()
            {
                x = 0;
                y = 0;
            }
            //Parameterised Constructor
            public Cpoint(int a, int b)
            {
                x = a;
                y = b;
            }

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }


            public override string ToString()
            {
                return ("(" + x + "," + y + ")");
            }

        }
        class Ccircle : Cpoint
        {
            double radius;
          
            public Ccircle(): base()
            {
                radius = 1;

            }
            public Ccircle(double r, int x, int y)
                : base(x, y)
            {
                radius = r;
            }
            public double Radius
            {
                get { return radius; }
                set { radius = value; }
            }
            public double circumference()
            {
                return 2 *Math.PI * radius;
            }

            public double diameter()
            {
                return 2 * radius;
            }
            //override this Area() fnt in cylinder class
            public virtual double Area()
            {
                return Math.PI * radius * radius;

            }
            public override  string ToString()
            {
                return "Radius :" + radius+ "Center Point :("+X+","+Y+")";
            }


        }
       
        class Ccylinder : Ccircle
        {
            double height;
            public Ccylinder():base()
            {
                height = 10; 

            }
            public Ccylinder(double h, double r, int mx, int my)
                : base(r, mx, my)
            {
                height = h;

            }
            public double Height
            {
                get { return height; }
                set { height = value; }
            }
            //surface Area Of Cylinder
            // 2pi r*r + 2 pi r h

            //new keyword is used to call base class fnt Area sometimes
            public override  double Area()
            {
                return (2 * base.Area() + base.circumference() * height);
                 
            }
        }
        static void Main(string[] args)
        {
            Ccircle c2 = new Ccircle();
            Ccircle c1 = new Ccircle(5, 1, 1);
            Console.WriteLine(c1);
            Console.WriteLine("Area ={0:F2}", c1.Area());
            Double A1 = c2.Area();
            Console.WriteLine("area of Circle c1 ={0:f}", A1);
            Ccylinder s1 = new Ccylinder(10, 7, 1, 2);
            Double A2 = s1.Area();
            Console.WriteLine("area of Cylinder s1 ={0:f}", A2);

            Ccircle ADr;
            Ccylinder s2 = new Ccylinder(12, 5, 1, 1);
            ADr = s2;
            double cylinderbaseArea = ADr.Area();
            Console.WriteLine("area of base of Cylinder s2 ={0:f}", cylinderbaseArea );


           // Ccircle c = s1;
           //Double  A3;
           //A3 = c.Area();
           // Console.WriteLine("area of Base Circle c1 ={0:f}", A3);
        }
    }
}
