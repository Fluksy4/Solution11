using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Display
    {
        public int n;
        public string dayOrNight;
        public double price;
        public Display()
        {
            GetValues();
        }
        private void GetValues()
        {
            //TODO
            n = int.Parse(Console.ReadLine());
            //TODO
            dayOrNight = Console.ReadLine();
        }
        
        public void Show()
        {
            Console.WriteLine(price);
        }      
    }
}
