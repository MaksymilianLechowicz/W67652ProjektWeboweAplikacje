using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W67652MaksymilianLechowiczProjektZAplikacjiWebowych.Entity;


    public class CrossDbContext : DbContext
    {
        private IConfiguration _configuration { get; }
        public DbSet<Plant> Plants { get; set; }
        public CrossDbContext(IConfiguration configuration) : base()
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer(@"server = 10.200.2.28; Database = projectZoologicalGarden;User Id = stud; Password =wsiz;",
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProjektWebow;Trusted_Connection=True;",

           x => x.MigrationsHistoryTable("__EFMigrationsHistory", "CrossProject"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

