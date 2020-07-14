using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.ToTable("Evento");
            
        }
    }
}
