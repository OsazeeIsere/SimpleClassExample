using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;
        //expression-bodied menber
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeeeeeeeee" +
                            "Haaaaaaaaaawwwww");
           }
        }

            
        //custom constructor
        //public Motorcycle(int intensity)
        //{
        //    driverIntensity = intensity;
        //}

        //method to set the name of rider 
        public void SetRiderName(string name)
        {
            //warning:variable assigned to itself. empty string sent out
           this.name = name;
        }

        //constructor chaining
        //default constructor
        //public Motorcycle() { }
        //public Motorcycle(int intensity)
        //    : this(intensity, "") { }
        //public Motorcycle(string name)
        //    : this(0, name) { }
        ////this is the master constructor that does all the real work
        //public Motorcycle(int intensity, string name)
        //{
        //    if (intensity > 10)
        //    {
        //        driverIntensity = 10;
        //    }
        //    else {
        //        driverIntensity = intensity;
        //    }
        //    this.name = name;
        //}

        //the traditional constructor chaining above can better be done 
        // with optional arguments
       public Motorcycle (int intensity=0, string name = "")
        {
            if (intensity > 10)
            {
                driverIntensity = 10;
            }
            else
            {
                driverIntensity = intensity;
            }
            this.name = name;

        }

    }
}
