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
    public class GetMelbourneHandler : IRequestHandler<GetMelbourne, List<Melbourne>>
    {
        private readonly Sims3Context context;
        public GetMelbourneHandler(Sims3Context context)
        {
            this.context = context;
        }

        public async Task<List<Melbourne>> Handle(GetMelbourne request, CancellationToken cancellationToken)
        {
            var fields = await this.context.Melbournes.Take(20).ToListAsync();
            return fields;
        }
    }
}
