using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace HubServiceEgiszHost
{
    class Program
    {
        static void Main()
        {
            var host = new WebServiceHost(typeof(ServiceNsi.ServiceNsi));
            try
            {
                host.Open();

                Console.WriteLine($"Servise started {host.Description.Name} adress {host.BaseAddresses[0]}...");
                Console.WriteLine($"Время старта {DateTime.Now}");
            }
            catch (Exception exception)
            {
                host.Abort();
                Console.WriteLine(exception.Message);
            }
            Console.ReadKey();
        }
    }
}
