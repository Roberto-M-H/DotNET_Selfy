using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHousePriceApp.Server.DataInsert
{
    public class InsertTexasRepository : IInsertRepository
    {
        private readonly Sims3Context context;

        public InsertTexasRepository(Sims3Context context)
        {
            this.context = context;
        }
        public void InsertHouse(City city)
        {
            this.context.Texas.Add((Texa)city);
            this.context.SaveChanges();
        }
    }
}
