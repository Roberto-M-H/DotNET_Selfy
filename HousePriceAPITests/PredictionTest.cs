using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using static BlazorHousePriceApp.Pages.PredictHousePriceTexas;

namespace HousePriceAPITests
{
    [TestClass]
    public class PredictionTest
    {
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
            var response = await httpclient.PostAsync(apiUrl, houseJSON);
            string responseAsString = response.Content.ReadAsStringAsync().Result;
            var predictedPrice = System.Text.Json.JsonSerializer.Deserialize<Prediction>(responseAsString);
            Assert.IsTrue(predictedPrice.Score > 0, "The predicted price was not greater than zero.");
        }
    }
}
