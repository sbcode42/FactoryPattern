using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace FactoryPattern
{
    class Motorcycle : IVehicle
    {
        public string Color { get; set; }

        public bool HasHandBreak { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving a {Color} motorcycle");
        }
    }
}
