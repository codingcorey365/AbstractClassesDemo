using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        //Default Constructor
        public Motorcycle()
        {
            Year = year;
            Make = make;
            Model = model;
        }
        //Property
        public int HasSideCar { get; set; }

        //Virtual Method Implemented

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle virtually driving in override!");
        }

        //Abstract Method Implemented
        public override void DriveAbstract()
        {
            Console.WriteLine("driving with the wind in my face!");
        }
    }
}
