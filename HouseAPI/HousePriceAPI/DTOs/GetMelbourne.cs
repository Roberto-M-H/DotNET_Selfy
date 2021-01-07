using System.Collections.Generic;
using MediatR;
using HousePriceAPI.Data;

namespace HousePriceAPI.DTOs
{
    public class GetMelbourne : IRequest<List<Melbourne>>
    {
    }
}