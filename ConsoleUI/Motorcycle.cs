﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicles
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Driving");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("virtual Motorcyle");
        }
    }
}
