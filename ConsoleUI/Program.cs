using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Object Initializer Syntax!!!!!
            Motorcycle indian = new Motorcycle()
            {
            Year = "2023",
            Make = "Indian",
            Model = "Scout Bobber",
            };

            //DotNotation
            Car ford1 = new Car();
            ford1.Year = "2023";
            ford1.Make = "Ford";
            ford1.Model = "Lightning";

            Vehicle dodge1 = new Car();
            dodge1.Year = "2023";
            dodge1.Make = "Dodge";
            dodge1.Model = "Challenger";

            Vehicle Honda1 = new Motorcycle();
            Honda1.Year = "2023";
            Honda1.Make = "Honda";
            Honda1.Model = "CBR1000";

            List<Vehicle> vehicles = new List<Vehicle>();
       
            vehicles.Add( indian );
            vehicles.Add( ford1 );
            vehicles.Add( dodge1 );
            vehicles.Add( Honda1 );

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Year, Make, Model. {veh.Year} {veh.Make} {veh.Model}");
                veh.DriveAbstract();
                veh.DriveVirtual();
                Console.WriteLine("-------------------------------------------------");
            }
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Done: Create an abstract class called Vehicle
             * Done: The vehicle class shall have three string properties Year, Make, and Model
             * Done: Set the defaults to something generic in the Vehicle class
             * Done: Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Done: Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Done: Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Done: Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Done: Provide the implementations for the abstract methods
             * Done: Only in the Motorcycle class will you override the virtual drive method
            */

            // Done: Create a list of Vehicle called vehicles

            /*
             * Done: Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Done: Set the properties with object initializer syntax
             */

            /*
             * Done: Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();


        }
    }
}
