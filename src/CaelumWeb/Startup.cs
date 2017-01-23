using Caelum.Infra.Dados;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Caelum.Infra.Dados.Repositorio;
using Caelum.Infra.Dados.Repositorio.Interfaces;


namespace CaelumWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=CadastroCaelum;Trusted_Connection=True;";
            services.AddDbContext<CaelumContext>(options => options.UseSqlServer(connection));
            services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            using (var context = app.ApplicationServices.GetService<CaelumContext>())
            {

                if (!context.Database.EnsureCreated())
                    context.Database.Migrate();
                context.EnsureSeedData();
            }
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areaRoute",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
