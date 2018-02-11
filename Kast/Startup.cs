using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Kast.Models;
using Kast.Models.Dnd5E;
using Kast.Models.Mocks;
using Kast.Models.Repositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Kast
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ITopicRepository, MockTopicRepository>();
            services.AddTransient<ICharecterRepository, MockCharecterRepository>();
            services.AddMvc();
            var connection = @"Server=(localdb)\mssqllocaldb;Database=Kast;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<Dnd5EContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Topic}/{action=Home}/{id?}");
            });
        }
    }
}
