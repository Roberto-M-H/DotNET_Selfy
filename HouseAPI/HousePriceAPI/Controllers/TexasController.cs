using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.ML;
using HousePriceAPI.DataModels;
using HousePriceAPI.Data;
using MediatR;
using HousePriceAPI.DTOs;


namespace HousePriceAPI.Controllers
{

    [Route("api/v1/statistics/Texas")]
    [ApiController]
    public class TexasStatisticsController : ControllerBase
    {
        private readonly IMediator mediator;
        public TexasStatisticsController(IMediator mediator)
        {

            this.mediator = mediator;


        }
        [HttpGet]
        public async Task<ActionResult<TexasStatistics>> Get()
        {
            var fields = await mediator.Send(new GetTexasStatistics());
            if (fields == null)
            {
                return NotFound();
            }

            return Ok(fields);
        }




    }


    [Route("api/v1/Texas")]
    [ApiController]
    public class TexasController : ControllerBase
    {
        private readonly PredictionEnginePool<TexasPriceData, TexasPricePrediction> _predictionEnginePool;
        private readonly IMediator mediator;

        public TexasController(PredictionEnginePool<TexasPriceData, TexasPricePrediction> predictionEnginePool, IMediator mediator)
        {
            this._predictionEnginePool = predictionEnginePool;
            this.mediator = mediator;


        }

        [HttpPost]
        public ActionResult<float> Post([FromBody] TexasPriceData data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            TexasPricePrediction predictedValue = _predictionEnginePool.Predict(modelName: "TexasPriceModel", example: data);




            return Ok(System.Text.Json.JsonSerializer.Serialize(predictedValue));
        }
        [HttpGet]
        public async Task<ActionResult<Texa>> Get()
        {
            var fields = await mediator.Send(new GetTexas());
            if (fields == null)
            {
                return NotFound();
            }
            return Ok(fields);
        }
    }
}
