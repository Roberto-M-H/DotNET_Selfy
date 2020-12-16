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

    [Route("api/v1/statistica/Texas")]
    [ApiController]
    public class TexasStatisticaController:ControllerBase
    {
        private readonly IMediator mediator;
        public TexasStatisticaController( IMediator mediator)
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
    [Route("api/v1/Melbourne")]
    [ApiController]
    public class MelbourneController : ControllerBase
    {
        private readonly PredictionEnginePool<MelbournePriceData, MelbournePricePrediction> _predictionEnginePool;
        public MelbourneController(PredictionEnginePool<MelbournePriceData, MelbournePricePrediction> predictionEnginePool)
        {
            this._predictionEnginePool = predictionEnginePool;
        }
        [HttpPost]
        public ActionResult<float> Post([FromBody] MelbournePriceData data)
        {
             if (!ModelState.IsValid)
             {
                 return BadRequest();
             }
           
            Console.WriteLine("Hello ");
            MelbournePricePrediction predictedValue = _predictionEnginePool.Predict(modelName: "MelbournePriceModel", example: data);



            return Ok(System.Text.Json.JsonSerializer.Serialize(predictedValue));
        }
    }


}
