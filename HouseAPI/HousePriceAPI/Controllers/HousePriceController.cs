using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.ML;
using HousePriceAPI.DataModels;
using HousePriceAPI.Data;
using MediatR;
using HousePriceAPI.DTOs;

namespace HousePriceAPI.Controllers
{

    [Route("api/v1/predictions")]
    [ApiController]
    public class HousePriceController : ControllerBase
    {
        private readonly PredictionEnginePool<HousePriceData, HousePricePrediction> _predictionEnginePool;
        public HousePriceData data;
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


            

            return Ok(System.Text.Json.JsonSerializer.Serialize(predictedValue));
        }
    }

    [Route("api/v1/statistics")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator mediator;
        public StatisticsController(IMediator mediator)
        {

            this.mediator = mediator;


        }
        [HttpGet]
        public async Task<ActionResult<Statistics>> Get()
        {
            var fields = await mediator.Send(new GetStatistics());
            if (fields == null)
            {
                return NotFound();
            }

            return Ok(fields);
        }




    }
}
