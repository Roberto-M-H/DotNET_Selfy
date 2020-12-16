﻿using System.Collections.Generic;
using MediatR;
using HousePriceAPI.Data;
namespace HousePriceAPI.DTOs
{
    public class GetTexasStatistics: IRequest<TexasStatistics>
    {
    }
}
