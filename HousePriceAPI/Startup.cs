using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.ML;
using HousePriceAPI.DataModels;
using HousePriceAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace HousePriceAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HousePriceAPI", Version = "v1" });
            });
            services.AddPredictionEnginePool<HousePriceData, HousePricePrediction>()
                .FromFile(modelName: "HousePriceModel", filePath: "MLmodels/MLModel.zip", watchForChanges: true);
            services.AddPredictionEnginePool<TexasPriceData, TexasPricePrediction>().FromFile(modelName: "TexasPriceModel", filePath: "MLmodels/Texas.zip",watchForChanges:true);
            services.AddPredictionEnginePool<MelbournePriceData, MelbournePricePrediction>().FromFile(modelName: "MelbournePriceModel", filePath: "MLmodels/MelbourneModel.zip", watchForChanges: true);
            services.AddDbContext<Sims3Context>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DataContext"));
            });
            services.AddMediatR(typeof(Startup).Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HousePriceAPI v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
