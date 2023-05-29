using ETicaretApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Persistence
{
    public class ETicaretAppDBContextFactory : IDesignTimeDbContextFactory<ETicaretAppDBContext>
    {
        public ETicaretAppDBContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ETicaretAppDBContext> optionsBuilder = new();
            optionsBuilder.UseSqlServer(Settings.ConnString);

            return new(optionsBuilder.Options);
        }
    }
}
