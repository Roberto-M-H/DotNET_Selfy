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
    public class GetStatisticsHandler : IRequestHandler<GetStatistics, List<Statistics>>
    {
        private readonly Sims3Context context;
        public GetStatisticsHandler(Sims3Context context)
        {
            this.context = context;
        }

        public async Task<List<Statistics>> Handle(GetStatistics request, CancellationToken cancellationToken)
        {
            var fields = await this.context.Statistics.OrderBy(h => h.City).ToListAsync();
            return fields;
        }
    }
}