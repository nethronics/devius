using Devius.Core.Context;
using Devius.Server.Common.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devius.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static AppSettings AddSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var section = configuration.GetSection(nameof(AppSettings));
            services.Configure<AppSettings>(section);
            return section.Get<AppSettings>();
        }


        public static void AddContext(this IServiceCollection services, AppSettings appConfig)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(appConfig.ConnectionString);
            });
        }
    }
}
