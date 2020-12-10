using System.Collections.Generic;
using MediatR;
using HousePriceAPI.Data;

namespace HousePriceAPI.DTOs
{
    public class GetTexas:IRequest<List<Texa>>
    {
    }
}
