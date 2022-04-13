using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal class BMW : Car,IAirconditioner
    {
        public  void StartAirconditioner()
        {
            Console.WriteLine("BMW kondisoner ise dusdu");
        }

        public override void StartDrive()
        {
            Console.WriteLine("BMW ise dusdu");
        }
    }
}
