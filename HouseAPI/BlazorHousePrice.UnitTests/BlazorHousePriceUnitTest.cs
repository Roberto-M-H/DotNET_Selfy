using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BlazorHousePriceApp.Server.DataInsert;
using Microsoft.EntityFrameworkCore;

namespace BlazorHousePrice.UnitTests
{
    [TestClass]
    public class BlazorHousePriceUnitTest
    {
        [TestMethod]
        public void InsertHouse_inserts_a_house_via_Sims3Context()
        {
            var mockSet = new Mock<DbSet<Texa>>();
            var mockContext = new Mock<Sims3Context>();
            mockContext.Setup(m => m.Texas).Returns(mockSet.Object);

            var service = new InsertTexasRepository(mockContext.Object);

            var house = new Texa()
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

            service.InsertHouse(house);

            mockSet.Verify(m => m.Add(It.IsAny<Texa>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}
