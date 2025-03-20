using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaininresponsibilitypattern
{
    internal class DD : Chainhandler
    {
        Chainhandler nexthandler;
        public void request(String request)
        {
            Console.WriteLine("Enter status of DD");
            String rep = Console.ReadLine();
            if (rep == "accepted")
            {
                Console.WriteLine("application is accepted by DD");
                nexthandler.request(request);
            }
            else
            {
                Console.WriteLine("application is rejected by DD");
            }

        }
        public void NextInChain(Chainhandler nexthandler)
        {
            this.nexthandler = nexthandler;
        }
    }
}
