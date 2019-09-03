using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Computer
    {
        public double HardDriveSize { get; set;}
        public double CPUSpeed { get; set;}
        public int CPUCores { get; set;}
        public string brand { get; set;}
        public bool IsOverClocked { get; set;}

        public Computer ()
        {
            HardDriveSize = 0;
            CPUSpeed = 0;
            CPUCores = 0;
            brand = string.Empty;
            IsOverClocked = false;
        }

        public double CalculatePrice ()
        {
            return 0.0;
        }
    }
}
