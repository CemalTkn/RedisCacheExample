
using StackExchange.Redis;

ConnectionMultiplexer redis = await ConnectionMultiplexer.ConnectAsync("localhost:1907");
//Sunucunun detayları var ise options üzerinden gidilebilir.
ISubscriber subscriber = redis.GetSubscriber();

await subscriber.SubscribeAsync("mychannel.*", (channel, message) => 
                              //Başında mychannel olan kanallara gönder.
{ 
    Console.WriteLine(message);
});

Console.Read();