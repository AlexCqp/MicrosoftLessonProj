using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ContosoPizza.Services;
using ContosoPizza.Models;
namespace ContosoPizza
{
    /// <summary>
    /// ����� ������������ ����������
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// �������������� ������ Sturtup
        /// </summary>
        /// <param name="configuration">����� ����-�������� �������� ����������</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// ����� �������� ����������
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// ������������ �������, ������� ������������ �����������
        /// </summary>
        /// <param name="services">��������� �������� ����������</param>
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IFoodItemSender<Pizza>, PizzaService>();
            //services.AddSingleton<IFoodItemSender<Wok>, WokService>();
            //services.AddSingleton<IFoodItemSender<Pancake>, PancakeService>();
            //services.AddSingleton<IFoodItemSender<Food>, Food>();
            services.AddSingleton<IFoodItemSender<Food>, FoodItemSender<Food>>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Food", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// ������������ ��������
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Food v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.Run(async (context) =>
            {
                //await context.Response
                //.BodyWriter.WriteAsync(System.Text.Encoding.UTF8.GetBytes
                //(System.Diagnostics.Process.GetCurrentProcess().ProcessName));
               // await context.Response.BodyWriter.WriteAsync(System.Text.Encoding.UTF8.GetBytes(pizzaSender.Get(1).Name));
            });
        }
    }
}
