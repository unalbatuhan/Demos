using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Calculation
{
    
  public  class Program
    {
        readonly int year = 2014;
        public static  void Main(string[] args)
        {
            
            Console.WriteLine("Enter Your Birthday :");
            int birtday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age =" + (year-birtday));
            Console.ReadKey();
        }
    }
}
