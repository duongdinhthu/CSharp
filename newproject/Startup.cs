using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using newproject.TestEntityFrameWork.entity;

using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
namespace newproject
{
    public class Startup
    {
        private IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"), new MariaDbServerVersion(new Version(8, 4, 0)))
            );

            // Add other services here
        }

        // Other methods in the `Startup` class

    }
}