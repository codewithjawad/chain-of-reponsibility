﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaininresponsibilitypattern
{
    public class ClusterHead:Chainhandler
    {
        Chainhandler nexthandler;
        public void request(String request)
        {
            Console.WriteLine("Enter status of cluster head");
            String rep = Console.ReadLine();
            if (rep == "accepted")
            {
                Console.WriteLine("application is accepted by cluster head");
                nexthandler.request(request);
            }
            else
            {
                Console.WriteLine("application is rejected by cluster head");
            }

        }
        public void NextInChain(Chainhandler nexthandler)
        {
            this.nexthandler = nexthandler;
        }
    }
}
