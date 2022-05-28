
using System.Configuration;
using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Producer;
using SolTechnology.Avro;
using Newtonsoft.Json;

namespace ClinicalEventProcessor
{
    public class ClinicalEventAvroSender
    {
        public static async Task Main()
        {
            string? EventHubConnectionString = ConfigurationManager.AppSettings.Get("AzureEventHubConnectionString");
            string? EventHubName = ConfigurationManager.AppSettings.Get("EventHubName");
            var producerClient = 
                new EventHubProducerClient(EventHubConnectionString, EventHubName);


            var jsonString = File.ReadAllText(@"D:\Research\Clinical-Event-Processor\ClinicalEventSender\Sample\sample_bom.json");
           
            var businessObjects = JsonConvert.DeserializeObject<BusinessObjectModel>(jsonString);
            byte[] avroBYtes = AvroConvert.Serialize(businessObjects);

            File.WriteAllBytes(@"D:\Research\Clinical-Event-Processor\ClinicalEventSender\Sample\sample_bom.avro", avroBYtes);

            EventData eventData = new(avroBYtes);
            EventDataBatch eventDataBatch = await producerClient.CreateBatchAsync();
            eventDataBatch.TryAdd(eventData);

            await producerClient.SendAsync(eventDataBatch);

            await Task.Yield();

        }

    }
}
