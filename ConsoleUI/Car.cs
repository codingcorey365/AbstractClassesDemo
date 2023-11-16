using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        //default constructor
        public Car()
        {
            Year = year;
            Make = make;
            Model = model;
        }

        //Property
        public bool HasTrunk { get; set; }

        

        //Abstract Method Implemented
        public override void DriveAbstract()
        {
            Console.WriteLine("Driving with all the windows down!");
        }
    }
}
