using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
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

        public IConfiguration Configuration { get; }
        private WebShopContext _context;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<WebShopContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebShopDev")));
            services.Add(new ServiceDescriptor(typeof(ICategoryService), typeof(CategoryService), ServiceLifetime.Transient));
            services.Add(new ServiceDescriptor(typeof(ICategoryRepo), typeof(CategoryRepo), ServiceLifetime.Scoped));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, WebShopContext context)
        {
            _context = context;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            // Fult
            var a = _context.Cors.Where(c => c.Enabled == true).ToList();
            var b = a.Select(n => n.Address).ToArray();
            // Fult

            app.UseCors(options => options.WithOrigins(b));

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
