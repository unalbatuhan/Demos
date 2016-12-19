using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstEncap
{
    class Program
    {
        class insan
        {
            //public string isim;
            //public int kilo;
            public string isim;
            private int kilo;
            public void setKilo(int kilo)
            {
                if(kilo<0)
                {
                    this.kilo = 0;
                }
                else
                {
                    this.kilo = kilo;
                }
                //this.kilo = kilo;
            }
            public int getKilo()
            {
                return kilo;

            }
        }
        static void Main(string[] args)
        {
            insan ali = new insan();
            ali.isim = "ali demir";
           ali.setKilo (80);
            insan veli = new insan();
            //veli.kilo = 47;
            Console.WriteLine("Batuhan UNAL");
            //Console.WriteLine("ali'nin kilosu" + ali.kilo);
            Console.WriteLine("alinin kilosu" + ali.getKilo());
            ali.setKilo(-10);
            Console.WriteLine("alinin kilosu" + ali.getKilo());
            Console.ReadLine();
        }
    }
}
