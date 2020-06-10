using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class Mobil : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Mobil Bergerak Di Atas Roda");
            Console.WriteLine("Dengan Bantuan Mesin Mobil");
        }
    }
}
