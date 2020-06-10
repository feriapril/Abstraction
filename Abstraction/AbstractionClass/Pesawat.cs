using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstractionClass
{
    public class Pesawat : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Pesawat Bergerak Dengan Cara Terbang");
            Console.WriteLine("Dengan Bantuan Mesin Jet");
        }
    }
}
