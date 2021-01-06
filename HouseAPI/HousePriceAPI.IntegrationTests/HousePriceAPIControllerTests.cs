using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace HousePriceAPI.IntegrationTests
{
    public class HousePriceAPIControllerTests : IClassFixture<WebApplicationFactory<HousePriceAPI.Startup>>
    {

        public HttpClient _client { get; }

        public HousePriceAPIControllerTests(WebApplicationFactory<HousePriceAPI.Startup> fixture)
        {
            _client = fixture.CreateClient();
        }

        [Fact] 
        public async Task Get_Should_Retrieve_Texas_Statistics() 
        { 
            var response = await _client.GetAsync("http://localhost:5000/api/v1/statistica/Texas");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var stats = JsonConvert.DeserializeObject<Data.TexasStatistics[]>(await response.Content.ReadAsStringAsync());
            stats.Should().HaveCount(1); 
        }
    }
}

