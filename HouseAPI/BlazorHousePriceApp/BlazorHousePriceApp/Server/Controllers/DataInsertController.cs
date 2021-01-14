using BlazorHousePriceApp.Server.DataInsert;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHousePriceApp.Server.Controllers
{

    [ApiController]
    [Route("api/v1/inserttexas")]
    public class DataInsertController : ControllerBase
    {
        private readonly Sims3Context context;

        private readonly IInsertRepository _repository;

        public DataInsertController(IInsertRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}", Name = "GetById")]

        public ActionResult<Texa> GetById(int id) => context.Texas.Find(id);

        [HttpPost]
        public IActionResult InsertHouse(Texa house)
        {
            _repository.InsertHouse(house);
            return CreatedAtAction(nameof(GetById), new { id = house.PredictionId }, house);
        }


    }
    
}
/*
    [ApiController]
    [Route("api/v1/inserttexas")]
    public class DataInsertController : ControllerBase
    {
        private readonly Sims3Context context;

        private readonly IInsertRepository _repository;

        public DataInsertController(IInsertRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Create(Texa student)
        {
            _repository.InsertHouse(student);
            //return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
            return Ok();
        }


    }
*/