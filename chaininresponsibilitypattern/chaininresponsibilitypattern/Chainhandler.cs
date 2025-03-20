using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaininresponsibilitypattern
{
    public interface Chainhandler
    {
        void request(String request);
        void NextInChain(Chainhandler nexthandler);
    }
}
