using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.ML;
using HousePriceAPI.DataModels;
using HousePriceAPI.Data;
using MediatR;
using HousePriceAPI.DTOs;
namespace HousePriceAPI.Controllers
{


    [Route("api/v1/Melbourne")]
    [ApiController]
    public class MelbourneController : ControllerBase
    {
        private readonly PredictionEnginePool<MelbournePriceData, MelbournePricePrediction> _predictionEnginePool;
        private readonly IMediator mediator;
        public MelbourneController(PredictionEnginePool<MelbournePriceData, MelbournePricePrediction> predictionEnginePool, IMediator mediator)
        {
            this._predictionEnginePool = predictionEnginePool;
            this.mediator = mediator;
        }
        [HttpPost]
        public ActionResult<float> Post([FromBody] MelbournePriceData data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            MelbournePricePrediction predictedValue = _predictionEnginePool.Predict(modelName: "MelbournePriceModel", example: data);


            return Ok(System.Text.Json.JsonSerializer.Serialize(predictedValue));
        }
        [HttpGet]
        public async Task<ActionResult<Melbourne>> Get()
        {
            var fields = await mediator.Send(new GetMelbourne());
            if (fields == null)
            {
                return NotFound();
            }
            return Ok(fields);
        }
    }

    [Route("api/v1/statistics/Melbourne")]
    [ApiController]
    public class MelbourneStatisticsController : ControllerBase
    {
        private readonly IMediator mediator;
        public MelbourneStatisticsController(IMediator mediator)
        {

            this.mediator = mediator;


        }
        [HttpGet]
        public async Task<ActionResult<MelbourneStatistics>> Get()
        {
            var fields = await mediator.Send(new GetMelbourneStatistics());
            if (fields == null)
            {
                return NotFound();
            }

            return Ok(fields);
        }
    }
}
