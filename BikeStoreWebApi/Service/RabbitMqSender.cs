using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace BikeStores.MSSQL.Service
{
    public class RabbitMqSender : IRabbitMqSender
    {
        public void PublishToMessageQueue(string integrationEvent, string eventData)
        {
            var factory = new ConnectionFactory();
            using (var connection = factory.CreateConnection())
            {

                using (var channel = connection.CreateModel())
                {

                    var body = Encoding.UTF8.GetBytes(eventData);
                    var properties = channel.CreateBasicProperties();
                    properties.Persistent = true;

                    channel.BasicPublish(
                        exchange: "library",
                        routingKey: integrationEvent,
                        basicProperties: properties,
                        body: body);

                }
            }
            Console.WriteLine(integrationEvent);
        }
    }
}
