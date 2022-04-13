using System;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW carBmw = new BMW();

            Mercedes carMer = new Mercedes();

            carBmw.StartDrive();
            carBmw.StartAirconditioner();

            carMer.StartDrive();
            carMer.StartAirconditioner();

            Car qaz31 = new Qaz31();
            qaz31.StartDrive();

        }
    }
}
