using System.Collections.Generic;
using HousePriceAPI.Data;
using MediatR;

namespace HousePriceAPI.DTOs
{
    public class GetStatistics : IRequest<List<Statistics>>
    {
    }
}