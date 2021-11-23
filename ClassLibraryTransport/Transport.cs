using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransport
{
    public class Transport
    {
        double taxiBase;
        double taxiDay;
        double taxiNight;
        double bus;
        double train;

        public int n;
        public string dayOrNight;

        double price;
        public Transport()
        {
            taxiBase = 0.70;
            taxiDay = 0.79;
            taxiNight = 0.90;
            bus = 0.09;
            train = 0.06;
            price = 0;            
        }
        public double GetPrice()
        {
            price = 0;
            if (n >= 100)
            {
                price = n * train;
            }
            else
            {
                if (n >= 20)
                {
                    price = n * bus;
                }
                else
                {
                    if (dayOrNight == "day")
                    {
                        price = taxiBase + n * taxiDay;
                    }
                    else
                    {
                        price = taxiBase + n * taxiNight;
                    }
                }
            }
            return price;
        }
    }
}
