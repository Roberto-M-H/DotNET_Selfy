using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousePriceAPI.Data;
using MediatR;
namespace HousePriceAPI.DTOs
{
    public class CreateBucharestPrediction:IRequest<Bucharest>
    {
    
        public float Rooms { get; set; }
        public float Surface { get; set; }
        public float Location { get; set; }
        public float Price { get; set; }
    }
}
