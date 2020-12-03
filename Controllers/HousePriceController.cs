using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.ML;
using Microsoft.ML;
using System.IO;
using HousePriceAPI.DataModels;

namespace HousePriceAPI.Controllers
{
    [Route("api/v1/predictions")]
    [ApiController]
    public class HousePriceController : ControllerBase
    {
        private readonly PredictionEnginePool<HousePriceData, HousePricePrediction> _predictionEnginePool;
        public HousePriceController(PredictionEnginePool<HousePriceData, HousePricePrediction> predictionEnginePool)
        {
            this._predictionEnginePool = predictionEnginePool;
        }

        [HttpPost]
        public ActionResult<float> Post([FromBody] HousePriceData data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Console.WriteLine(data.Surface);
            HousePricePrediction predictedValue = _predictionEnginePool.Predict(modelName: "HousePriceModel", example: data);


            //MLContext mlContext = new MLContext();
            //DataViewSchema predictionPipelineSchema;
            //ITransformer predictionPipeline = mlContext.Model.Load("MLmodels/MLModel.zip", out predictionPipelineSchema);
            //PredictionEngine<HousePriceData, HousePricePrediction> predictionEngine = mlContext.Model.CreatePredictionEngine<HousePriceData, HousePricePrediction>(predictionPipeline);
            //HousePriceData data2 = new HousePriceData() { Rooms = 3f, Surface = 65f, Location = 3f, Price = 0f };
            //HousePricePrediction prediction = predictionEngine.Predict(data2);

            return Ok(predictedValue.Score);
        }
    }
}
