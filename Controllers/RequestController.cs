using Microsoft.AspNetCore.Mvc;
using WebApiForRequests.Dtos;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace WebApiForRequests.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController : ControllerBase
    {
        private readonly ILogger<RequestController> _logger;

        public RequestController(ILogger<RequestController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "SendRequest")]
        public async Task<bool> Send(RequestDto request)
        {
            // проверка паспортных данных

            // проверки суммы кредита

            // проверка по черному списку

            // проверка других кредитов

            // вернуть решение о выдаче кредита, с указанием причины

            await SendToRabbit(request);
            return true;
        }

        private async Task SendToRabbit(RequestDto request)
        {
            ConnectionFactory factory = new ConnectionFactory();          //подключение к rabbit
            factory.UserName = "guest";                                   //подключение к rabbit
            factory.Password = "guest";                                   //подключение к rabbit
            factory.VirtualHost = "/";                                    //подключение к rabbit
            factory.HostName = "localhost";                               //подключение к rabbit
                                                                          //подключение к rabbit
            IConnection conn = await factory.CreateConnectionAsync();     //подключение к rabbit

            string exchange = "BankExchange";
            string routingKey = "route";
            string queue = "CreditRequestsIn";

            IChannel channel = await conn.CreateChannelAsync();                  
            await channel.ExchangeDeclareAsync(exchange, ExchangeType.Direct);   
            await channel.QueueDeclareAsync(queue, false, false, false, null);   
            await channel.QueueBindAsync(queue, exchange, routingKey, null);     

            byte[] messageBytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(request));
            await channel.BasicPublishAsync(exchange, routingKey, false, messageBytes);

            await channel.CloseAsync();
            await conn.CloseAsync();
        }
    }
}
