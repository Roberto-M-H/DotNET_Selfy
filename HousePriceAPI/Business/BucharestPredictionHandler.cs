using HousePriceAPI.DataModels;
using Microsoft.Extensions.ML;
using HousePriceAPI.Data;
using HousePriceAPI.DTOs;
using System.Threading.Tasks;
using System.Threading;
using HousePriceAPI.Controllers;
namespace HousePriceAPI.Business
{
    /*
    public class BucharestPredictionHandler
    {
        private readonly PredictionEnginePool<HousePriceData, HousePricePrediction> _predictionEnginePool;
        BucharestPredictionHandler(PredictionEnginePool<HousePriceData,HousePricePrediction> predictionEnginePool)
        {
            this._predictionEnginePool = predictionEnginePool;
        }
        public async Task <float> Handle(CreateBucharestPrediction request, CancellationToken cancellationToken)
        {
            HousePricePrediction predictedValue = _predictionEnginePool.Predict(modelName: "HousePriceModel", example: data);
        }
    }*/
}
