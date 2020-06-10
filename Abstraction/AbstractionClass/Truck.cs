using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstractionClass
{
    public class Truck : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Mobil Bergerak Di Atas Sepuluh Roda");
            Console.WriteLine("Dengan Bantuan Mesin Truck");
        }
    }
}
