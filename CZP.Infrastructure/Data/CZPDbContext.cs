using CZP.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CZP.Infrastructure.Data
{
    public class CZPDbContext : DbContext
    {
        public CZPDbContext(DbContextOptions<CZPDbContext> options) : base(options)
        {
        }


        public DbSet<EnterpriseInfo> EnterpriseInfos { get; set; }

        public DbSet<ManagerInfo> ManagerInfos { get; set; }

    }
}
