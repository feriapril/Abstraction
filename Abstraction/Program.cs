using System;
//using Abstraction.AbstractionClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kendaraan kendaraan;

            //kendaraan = new Pesawat();
            //kendaraan.Bergerak();

            //Console.WriteLine();
            //kendaraan = new Mobil();
            //kendaraan.Bergerak();

            //Console.WriteLine();
            //kendaraan = new Motor();
            //kendaraan.Bergerak();

            //Console.WriteLine();
            //kendaraan = new Truck();
            //kendaraan.Bergerak();

            //Console.WriteLine();
            //kendaraan = new Bus();
            //kendaraan.Bergerak();

            IKendaraan kendaraan;

            kendaraan = new Pesawat();
            kendaraan.Bergerak();

            Console.WriteLine();
            kendaraan = new Mobil();
            kendaraan.Bergerak();

            Console.WriteLine();
            kendaraan = new Motor();
            kendaraan.Bergerak();

            Console.WriteLine();
            kendaraan = new Truck();
            kendaraan.Bergerak();


            Console.WriteLine();
            kendaraan = new Bus();
            kendaraan.Bergerak();

            Console.ReadKey();

        }
    }
}
