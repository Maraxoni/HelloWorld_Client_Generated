using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class ClientMain
    {
        static void Main(string[] args)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress("http://localhost:8080/HelloWorldService");
            HelloWorldClient client = new HelloWorldClient(binding, endpoint);
            Console.WriteLine(client.GetHelloWorldAsString("Sample"));
        }
    }
}
