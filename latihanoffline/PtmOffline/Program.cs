using System;

namespace PtmOffline{
    class Program{
        static void Main(string[] args)
        {
            Laptop Asus = new Laptop();
            Laptop Axio = new Laptop();
            Processor Intel = new Processor();


            Asus.hargaLaptop();
            Axio.hargaLaptop();
            Asus.PublicMethod();
            Console.WriteLine(Intel.CORE);
            Intel.hargaCORE();

        }
    }
    class Laptop
    {
        private int harga = 1500000;
        public void hargaLaptop()
        {
            Console.WriteLine(harga);
        }
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }
        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
        }
    }

    class Processor
    {
        public int CORE = 100000;
        public void hargaCORE()
        {
            Console.WriteLine("16 bit");
        }

        private void speed()
        {
            Console.WriteLine("8 bit");
        }
    }
}