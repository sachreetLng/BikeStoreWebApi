namespace BikeStores.MSSQL.Service
{
    public interface IRabbitMqSender
    {
        public bool PublishToMessageQueue(string integrationEvent, string eventData);
    }
}
