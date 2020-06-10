using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstractionClass
{
    public class Mobil : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Mobil Bergerak Di Atas Roda");
            Console.WriteLine("Dengan Bantuan Mesin Mobil");
        }
    }
}
