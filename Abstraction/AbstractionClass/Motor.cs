using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstractionClass
{
    public class Motor : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Motor Bergerak Di Atas Dua Roda");
            Console.WriteLine("Dengan Bantuan Mesin Motor");
        }
    }
}
