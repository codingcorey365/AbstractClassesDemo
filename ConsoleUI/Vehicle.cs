using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        

        //Default Constructor
        public Vehicle()
        {
            Year = year;
            Make = make;
            Model = model;
        }

        //Fields
        public string year;
        public string make;
        public string model;

        //Properties
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        //Abstract Methods
        public abstract void DriveAbstract();

        //Virtual Method
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving Virtually");
        }



    }
     
}
