using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using HousePriceAPI.DTOs;
using HousePriceAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Linq;

namespace HousePriceAPI.Business
{
    public class GetTexasStatisticsHandler : IRequestHandler<GetTexasStatistics, TexasStatistics>
    {
        private readonly Sims3Context context;
        public GetTexasStatisticsHandler(Sims3Context context)
        {
            this.context = context;
        }

        public async Task<TexasStatistics> Handle(GetTexasStatistics request, CancellationToken cancellationToken)
        {
            var fields = await this.context.Texas
                                    .Select(p => new { p.Price, p.Grade, p.SqftLot }).ToListAsync();
            var mediaPreturi = fields.Select(p => p.Price).Average();
            var mediaGrades = fields.Select(p => p.Grade).Average();
            var mediaArea = fields.Select(p => p.SqftLot).Average();
            var maximPrice = fields.Select(p => p.Price).Max();
            var minimPrice = fields.Select(p => p.Price).Min();
            return new TexasStatistics { price = mediaPreturi, grade = mediaGrades, sqftLot = mediaArea, maxPrice = maximPrice, minPrice = minimPrice  };

            

        }
    }
}
