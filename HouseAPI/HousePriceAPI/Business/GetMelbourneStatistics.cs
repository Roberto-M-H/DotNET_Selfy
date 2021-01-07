using System.Threading.Tasks;
using MediatR;
using HousePriceAPI.DTOs;
using HousePriceAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Linq;

namespace HousePriceAPI.Business
{
    public class GetMelbourneStatisticsHandler : IRequestHandler<GetMelbourneStatistics, MelbourneStatistics>
    {
        private readonly Sims3Context context;
        public GetMelbourneStatisticsHandler(Sims3Context context)
        {
            this.context = context;
        }

        public async Task<MelbourneStatistics> Handle(GetMelbourneStatistics request, CancellationToken cancellationToken)
        {
            var fields = await this.context.Melbournes
                                    .Select(p => new { p.Price}).ToListAsync();
            var Priceuri = fields.Select(p => p.Price).Average();
            var maximPrice = fields.Select(p => p.Price).Max();
            var minimPrice = fields.Select(p => p.Price).Min();
            return new MelbourneStatistics { price = Priceuri, maxPrice = maximPrice, minPrice = minimPrice };



        }
    }
}
