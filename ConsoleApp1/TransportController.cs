using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTransport;

namespace ConsoleApp1
{
    class TransportController
    {
        Transport transport;
        Display display;
        public TransportController()
        {
            display = new Display();
            transport = new Transport();
            transport.n = display.n;
            transport.dayOrNight = display.dayOrNight;
            display.price = transport.GetPrice();
            display.Show(); 
        }
    }
}
