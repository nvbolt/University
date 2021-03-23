using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using University.API.Configs;
using University.API.ServicesConfiguration;
using University.DataLayer.Extensions;

namespace University
{
    public class Startup
    {
        private AppConfig AppConfig { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            this.AppConfig = this.Configuration.Get<AppConfig>();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.RegistrationRepositories();

            services.AddControllers();
            services.ConfigureSwagger();
            services.ConfigureDbContext(AppConfig.PostgresConfig.ConnectionString);
            services.ConfigureAuthentication(this.AppConfig.AuthConfig);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Velvetech University"));

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
