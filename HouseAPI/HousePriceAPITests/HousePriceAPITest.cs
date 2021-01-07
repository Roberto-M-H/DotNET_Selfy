using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using HousePriceAPI.Data;
namespace HousePriceAPITests
{
    [TestClass]
    public class StatisticsTest
    {
        private string apiUrl = "http://localhost:5000/api/v1/statistics/Texas";
        [TestMethod]
        public async System.Threading.Tasks.Task IsGradeinRange()
        {
            //Arrange
            var httpclient = new HttpClient();
            //Act
            var response = await httpclient.GetAsync(apiUrl);
            string responseAsString = response.Content.ReadAsStringAsync().Result;
            var statistics = System.Text.Json.JsonSerializer.Deserialize<TexasStatistics>(responseAsString);
            //Assert
            Assert.IsTrue(statistics.grade <= 10 && statistics.grade >= 0, "The grade is not in range (0,10)");

        }


        [TestMethod]
        public async System.Threading.Tasks.Task IsPriceinRange()
        {
            //Arrange
            var httpclient = new HttpClient();
            //Assert
            var response = await httpclient.GetAsync(apiUrl);
            string responseAsString = response.Content.ReadAsStringAsync().Result;
            var statistics = System.Text.Json.JsonSerializer.Deserialize<TexasStatistics>(responseAsString);
            //Act
            Assert.IsTrue(statistics.price <= statistics.maxPrice && statistics.price >= statistics.minPrice, "The average price is not in range (min,max)");

        }
        [TestMethod]
        public async System.Threading.Tasks.Task IsMaxPriceGreaterThanZero()
        {
            //Arrange
            var httpclient = new HttpClient();
            //Act
            var response = await httpclient.GetAsync(apiUrl);
            string responseAsString = response.Content.ReadAsStringAsync().Result;
            var statistics = System.Text.Json.JsonSerializer.Deserialize<TexasStatistics>(responseAsString);
            //Assert
            Assert.IsTrue(statistics.maxPrice > 0, "The maxim price is null or negative");

        }
        [TestMethod]
        public async System.Threading.Tasks.Task IsMinPriceGreaterThanZero()
        {
            //Arrange
            var httpclient = new HttpClient();
            //Act
            var response = await httpclient.GetAsync(apiUrl);
            string responseAsString = response.Content.ReadAsStringAsync().Result;
            var statistics = System.Text.Json.JsonSerializer.Deserialize<TexasStatistics>(responseAsString);
            //Assert
            Assert.IsTrue(statistics.minPrice > 0, "The maxim price is null or negative");

        }
        public async System.Threading.Tasks.Task IsMaxGreaterThanMin()
        {
            //Arrange
            var httpclient = new HttpClient();
            //Act
            var response = await httpclient.GetAsync(apiUrl);
            string responseAsString = response.Content.ReadAsStringAsync().Result;
            var statistics = System.Text.Json.JsonSerializer.Deserialize<TexasStatistics>(responseAsString);
            //Assert
            Assert.IsTrue(statistics.minPrice <= statistics.maxPrice, "The maxim price is null or negative");

        }
    }

    [TestClass]
    public class PredictionTest
    {
        //Arrange
        private string apiUrl = "http://localhost:5000/api/v1/Texas";
        [TestMethod]
        public async System.Threading.Tasks.Task IsPredictionGreaterThanZeroAsync()
        {
            var house = new HousePriceAPI.Data.Texa()
            {
                Id = 7129300520,
                Date = "20141013T000000",
                Price = 0,
                Bedrooms = 2,
                Bathrooms = 1,
                SqftLiving = 1180,
                SqftLot = 5650,
                Floors = 6,
                Waterfront = 0,
                View = 0,
                Condition = 3,
                Grade = 8,
                SqftAbove = 1180,
                SqftBasement = 0,
                YrBuilt = 1955,
                YrRenovated = 0,
                Zipcode = 98178,
                Lat = 47.5112,
                Long = -122.257,
                SqftLiving15 = 1340,
                SqftLot15 = 5650
            };
            var houseJSON = new StringContent(JsonConvert.SerializeObject(house), Encoding.UTF8, "application/json");
            var httpclient = new HttpClient();
            //Act
            var response = await httpclient.PostAsync(apiUrl, houseJSON);
            string responseAsString = response.Content.ReadAsStringAsync().Result;


            var predictedPrice = System.Text.Json.JsonSerializer.Deserialize<Prediction>(responseAsString);
            //Assert
            Assert.IsTrue(predictedPrice.Score > 0, "The predicted price was not greater than zero.");
        }
    }
    public class Prediction
    {
        public double Score { get; set; }
    }
    [TestClass]
    public class PredictionTestMB
    {
        //Arrange
        private string apiUrl = "http://localhost:5000/api/v1/Melbourne";
        [TestMethod]
        public async System.Threading.Tasks.Task IsPredictionGreaterThanZeroAsync()
        {
            var house = new HousePriceAPI.Data.Melbourne()
            {
                Rooms = 3,
                Price = 1912000,
                Distance = 9.7,
                Postcode = "3103",
                Bedroom2 = "2",
                Bathroom = 1,
                Landsize = 844,
                BuildingArea = 0,
                YearBuilt = 0,
                CouncilArea = "Boroondara City Council",
                Regionname = "Southern Metropolitan",
            };
            var houseJSON = new StringContent(JsonConvert.SerializeObject(house), Encoding.UTF8, "application/json");
            var httpclient = new HttpClient();
            //Act
            var response = await httpclient.PostAsync(apiUrl, houseJSON);
            string responseAsString = response.Content.ReadAsStringAsync().Result;

            System.Console.WriteLine(responseAsString);
            var predictedPrice = System.Text.Json.JsonSerializer.Deserialize<Prediction>(responseAsString);
            //Assert
            Assert.IsTrue(predictedPrice.Score > 0, "The predicted price was not greater than zero.");
        }
    }
}
