using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal class Mercedes : Car,IAirconditioner
    {
        public void StartAirconditioner()
        {
            Console.WriteLine("Kondisoner ise dusdu");
        }

        public override void StartDrive()
        {
            Console.WriteLine("Masin ise dusdu");
        }
    }
}
