using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using LottResultsApi.Models;

namespace LottResultsApi.DAL
{
    public class LottResultContext : DbContext
    {
        public LottResultContext() : base("LottResultContext")
        {

        }

        public DbSet<LottResultDesc> LottResultDescs { get; set; }
        public DbSet<LottResult> LottResults { get; set; }
        public DbSet<LottResultDetail> LottResultDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}