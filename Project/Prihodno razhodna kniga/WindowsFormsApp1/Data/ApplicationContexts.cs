using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Data
{
    /// <summary>
    /// Main ApplicationContext class
    /// Used to work with the database
    /// </summary>
    public class ApplicationContexts : DbContext
    {
        /// <summary>
        /// Emptry constructor
        /// </summary>
        public ApplicationContexts()
        {

        }

        /// <summary>
        /// Constructor with options
        /// </summary>
        /// <param name="options"></param>
        public ApplicationContexts(DbContextOptions options)
            :base(options)
        {

        }
        
        /// <summary>
        /// Dbset of PersonRegister table
        /// </summary>
        public virtual DbSet<PersonRegister> PersonRegisters { get; set; }

        /// <summary>
        /// Dbset of PersonBookTypes table
        /// </summary>
        public virtual DbSet<PersonBookType> PersonBookTypes { get; set; }

        /// <summary>
        /// Dbset of PersonAccounts table
        /// </summary>
        public virtual DbSet<PersonAccount> PersonAccounts { get; set; }

        /// <summary>
        /// Dbset of RevenueExpenditureBooks table
        /// </summary>
        public virtual DbSet<RevenueExpenditureBook> RevenueExpenditureBooks { get; set; }

        /// <summary>
        /// Override method used to connect with database
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    (Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// Override method used to create the model of the table
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
