using CleanArchitecture.Application.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Infrastructure.Context;




namespace CleanArchitecture.Infrastructure.Context
{
    public static class ServiceExtentions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("test");
            services.AddDbContext<DataDbContext>(opt => opt.UseSqlite(connectionString));

        
        }
    }
}
