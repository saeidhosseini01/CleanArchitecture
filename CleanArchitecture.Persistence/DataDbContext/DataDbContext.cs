using CleanArchitecture.Domain.Entitis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace CleanArchitecture.Persistence.DataDbContext
{


    public class DataDbContext:DbContext
    {





        public DataDbContext(DbContextOptions<DataDbContext>  options) : base (options)
        {
                
        }
       public  DbSet<User> Users {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
