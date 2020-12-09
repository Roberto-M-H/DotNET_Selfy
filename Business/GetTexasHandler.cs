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
    public class GetTexasHandler : IRequestHandler<GetTexas, List<Texa>>
    {
        private readonly Sims3Context context;
        public GetTexasHandler(Sims3Context context)
        {
            this.context = context;
        }

        public async Task<List<Texa>> Handle(GetTexas request, CancellationToken cancellationToken)
        {
            var fields = await this.context.Texas.Take(20).ToListAsync();
            return fields;
        }
    }
}
