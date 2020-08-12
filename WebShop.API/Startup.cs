using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebShop.API.App_Start;
using WebShop.API.Models;
using WebShop.API.Repository;
using WebShop.API.Services;

namespace WebShop.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IWebShopService _webShopService;
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionstring = Configuration.GetConnectionString("WebShopDev");
            services.AddMvc();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<IWebShopService, WebShopService>();
            services.AddDbContext<WebShopContext>(options => options.UseSqlServer(connectionstring));
            DbUpConfig.InitDatabse(connectionstring);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IWebShopService webShopService)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            var cors = webShopService.GetListOfAllActiveCors();

            app.UseCors(options => options.WithOrigins(cors));

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
