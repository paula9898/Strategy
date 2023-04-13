using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.DeliveryStrategies
{
    public class PostDelivery : IDeliveryStrategy
    {
        
        public void Deliver(Client client)
        {
            List<Client> clientDetails = new List<Client>();

            Console.WriteLine("Name: ");
            client.Name = Console.ReadLine();

            Console.WriteLine("Surname: ");
            client.Surname = Console.ReadLine();

            Console.WriteLine("City: ");
            client.City = Console.ReadLine();

            Console.WriteLine("Street: ");
            client.Street = Console.ReadLine();

            Console.WriteLine("PostalCode: ");
            client.PostalCode = Console.ReadLine();

            Console.WriteLine("ContactNumber: ");
            client.ContactNumber = Convert.ToInt32(Console.ReadLine());

            clientDetails.Add(new Client() { Name = client.Name, Surname = client.Surname });

            Console.WriteLine("Contact information and shipping adress");

            foreach (Client detail in clientDetails)
            {
                Console.WriteLine(detail.Name + detail.Surname);
            }

        }
    }
}
