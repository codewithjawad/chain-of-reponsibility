using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaininresponsibilitypattern
{
    internal class Examinationcell: Chainhandler
    {
        Chainhandler nexthandler;
        public void request(String request)
        {
            Console.WriteLine("Enter status of Examinationcell");
            String rep = Console.ReadLine();
            if (rep == "accepted")
            {
                Console.WriteLine("application is accepted by Examinationcell");
                Console.WriteLine("Email Sent");
                
            }
            else
            {
                Console.WriteLine("application is rejected by Examinationcell");
            }

        }
        public void NextInChain(Chainhandler nexthandler)
        {
            this.nexthandler = nexthandler;
            
        }
    }
}
