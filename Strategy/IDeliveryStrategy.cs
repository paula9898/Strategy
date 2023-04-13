using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IDeliveryStrategy
    {
        void Deliver(Client client);//Strategy: an interface defining the common operation we intend to perform

    }
}
