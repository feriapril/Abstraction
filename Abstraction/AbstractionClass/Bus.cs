using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstractionClass
{
    public class Bus : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Bus Bergerak Di Atas Delapan Roda");
            Console.WriteLine("Dengan Bantuan Mesin Bus");
        }
    }
}
