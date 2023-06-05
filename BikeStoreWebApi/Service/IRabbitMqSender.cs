namespace BikeStores.MSSQL.Service
{
    public interface IRabbitMqSender
    {
        public void PublishToMessageQueue(string integrationEvent, string eventData);
    }
}
