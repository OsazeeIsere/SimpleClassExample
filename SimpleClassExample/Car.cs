using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        //the state of the car
        public int currentSpeed;
        public string petName;

        //the funtionality of the car.
        //using expression-bodied member syntax inroduced in chapter 6
        public void PrintState() => Console.WriteLine("{0} is going {1} MPH.", petName, currentSpeed);
        public void SpeedUp(int delta) => currentSpeed += delta;

        //a default custom constructor
        public Car()
        {
            petName = "Pencil Light";
            currentSpeed = 50;
        }

        // here currentSpeed will receive an initial value of int zero
        public Car(string pn)
        {
            petName = pn;
        }
        //here the caller is allowed to set the full state of the Car
        public Car(string pn,int cs)
        {
            petName = pn;
            currentSpeed = cs;
        }

    }

}
