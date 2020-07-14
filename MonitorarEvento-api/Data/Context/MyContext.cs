using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
	public class MyContext : DbContext
	{
        #region "DbSets"
        public DbSet<Evento> Evento { get; set; }
		#endregion

		public MyContext(DbContextOptions<MyContext> options) : base(options)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Evento>(new EventoMap().Configure);
        }
	}
}
