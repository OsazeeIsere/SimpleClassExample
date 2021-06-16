using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> fun with class");
            Car myCar = new Car("Big For Notting",80);
            myCar.PrintState();

            //increase the speed of the car by 30
            myCar.SpeedUp(30);
            Console.WriteLine("After increasing the speed");
            myCar.PrintState();

            //speed up the car a few times and print state
            for (int i = 0; i < 5; i++)
            {
                myCar.SpeedUp(10);
                myCar.PrintState();
            }

            //invoking the default constructor
            Car pencilLight = new Car();
            pencilLight.PrintState();

            //make a car called Egui with 0 speed
            Car egui = new Car("Egui");
            egui.PrintState();
            // make a car called danfo with speed 80
            Car danfo = new Car("Danfo", 80);
            danfo.PrintState();

            //with motorcycle
            Console.WriteLine("=> accessing the motorcyle method");
            Motorcycle bike = new Motorcycle(50);
            bike.PopAWheely();
            bike.SetRiderName("John");
            Console.WriteLine("Rider name is:{0} and the safe intensity is: {1}", bike.name,bike.driverIntensity);
            //prints empty name value!
            //to correct this use the "this" keyword to get variabe in the class scope
            //or you simply rename to remove the ambiguity
            Console.ReadLine();
        }
    }
}
