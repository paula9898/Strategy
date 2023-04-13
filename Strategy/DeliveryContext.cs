using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DeliveryContext //anything that requires changing behaviors and holds a reference to a Strategy
    {
        private IDeliveryStrategy _deliveryStrategy;

        public void SetDeliveryStrategy(IDeliveryStrategy deliveryStrategy)
        {
            _deliveryStrategy = deliveryStrategy;
        }

        public void Deliver(Client client)
        {
            _deliveryStrategy.Deliver(client);
        }

    }
}
