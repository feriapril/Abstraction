using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class Truck : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Mobil Bergerak Di Atas Sepuluh Roda");
            Console.WriteLine("Dengan Bantuan Mesin Truck");
        }
    }
}
