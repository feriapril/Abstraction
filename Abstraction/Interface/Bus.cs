using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class Bus : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Bus Bergerak Di Atas Delapan Roda");
            Console.WriteLine("Dengan Bantuan Mesin Bus");
        }
    }
}
