using CZP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CZP.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString)
            => services.AddDbContext<CZPDbContext>(options=>
            options.UseSqlServer(connectionString)); // will be created in web project root

    }
}
