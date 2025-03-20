using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaininresponsibilitypattern
{
    internal class Doctor:Chainhandler
    {
        Chainhandler nexthandler;
        public void request(String request)
        {
            Console.WriteLine("Enter status of Doctor");
            String rep = Console.ReadLine();
            if (rep == "accepted")
            {
                Console.WriteLine("application is accepted by Doctor");
                nexthandler.request(request);
            }
            else
            {
                Console.WriteLine("application is rejected by Doctor");
            }

        }
        public void NextInChain(Chainhandler nexthandler)
        {
            this.nexthandler = nexthandler;
        }
    }
}
