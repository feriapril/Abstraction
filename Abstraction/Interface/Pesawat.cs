using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class Pesawat : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Pesawat Bergerak Dengan Cara Terbang");
            Console.WriteLine("Dengan Bantuan Mesin Jet");
        }
    }
}
