using System;
using Strategy.DeliveryStrategies;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client();

            IDeliveryStrategy deliveryStrategy;

            deliveryStrategy = new PostDelivery();

            deliveryStrategy.Deliver(client);

            Console.ReadKey();

        }
    }
}
