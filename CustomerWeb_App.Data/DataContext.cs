using CustomerWeb_App.Data.DataModels;
using CustomerWeb_App.Data.RepositoryServices.Contracts;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomerWeb_App.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public static DataContext Create()
        {
            return new DataContext();
        }
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(new SqlConnection(ServicesExtensions.CustomersConnectionString));
        }    
        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasNoKey().ToView(null);
        }

            public new void Dispose()
        {
            throw new NotImplementedException();
        }
        
        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
