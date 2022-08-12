using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace car_new_override
{
    class Program
    {
        class Car
        {
            public virtual void DescribeCar()
            {
                System.Console.WriteLine("Four wheels and an engine.");
            }
        }

        // Define the derived classes
        class ConvertibleCar : Car
        {
            public new  void DescribeCar()
            {
           //  base.DescribeCar();
                System.Console.WriteLine("A roof that opens up.");
            }
        }

        class Minivan : Car
        {
            public override void DescribeCar()
            {
            //  base.DescribeCar();
                System.Console.WriteLine("Carries seven people.");
            }
        }

        static void Main(string[] args)
        {
            ConvertibleCar c = new ConvertibleCar();
            Car car1 = new Car();
            car1.DescribeCar();
            System.Console.WriteLine("----------");
            ConvertibleCar car2 = new ConvertibleCar();
            car2.DescribeCar();
            System.Console.WriteLine("----------");
            Minivan car3 = new Minivan();
            car3.DescribeCar();
            System.Console.WriteLine("----------");
            Car[] cars = new Car[3];
            cars[0] = car1;
            cars[1] = car2;
            cars[2] = car3;
            foreach (Car vehicle in cars)
            {
                System.Console.WriteLine("Car object: " + vehicle.GetType());
                vehicle.DescribeCar();
                System.Console.WriteLine("----------");
            }


            Console.ReadLine();







        }
    }
}
