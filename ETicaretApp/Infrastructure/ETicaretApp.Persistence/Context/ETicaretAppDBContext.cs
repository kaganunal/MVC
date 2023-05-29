using Core.ETicaretApp.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Persistence.Context
{
    public class ETicaretAppDBContext:DbContext
    {
        public ETicaretAppDBContext()
        {

        }
        public ETicaretAppDBContext(DbContextOptions options) : base(options)
        {

        }
        //IConfiguration _configuration;
        //public ETicaretAppDBContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(Settings.ConnString);



    }
}
