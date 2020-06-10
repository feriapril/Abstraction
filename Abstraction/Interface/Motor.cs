using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class Motor : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Motor Bergerak Di Atas Dua Roda");
            Console.WriteLine("Dengan Bantuan Mesin Motor");
        }
    }
}
