using Microsoft.AspNetCore.Mvc;
using WebApiForRequests.Dtos;

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
        public bool Send(RequestDto request)
        {
            // проверка паспортных данных

            // проверки суммы кредита

            // проверка по черному списку

            // проверка других кредитов

            // вернуть решение о выдаче кредита, с указанием причины



            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            return true;
        }
    }
}
