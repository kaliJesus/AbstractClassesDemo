using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicles
    {
        public string Year { get; set; } = "2023";
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Corolla";

        public abstract void DriveAbstract();


        public virtual void DriveVirtual()
        {
            Console.WriteLine("virtual drive ");
        }

    }


}
