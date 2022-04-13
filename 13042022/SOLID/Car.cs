using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal abstract class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }

        public abstract void StartDrive();

    }
}
