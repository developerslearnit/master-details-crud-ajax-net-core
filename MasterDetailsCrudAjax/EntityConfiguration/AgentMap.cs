using MasterDetailsCrudAjax.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterDetailsCrudAjax.EntityConfiguration;

public class AgentMap : IEntityTypeConfiguration<Agent>
{
    public void Configure(EntityTypeBuilder<Agent> builder)
    {
        builder.ToTable(nameof(Agent));
        builder.HasKey(x => x.AgentId);
        builder.Property(x => x.AgentCode).IsRequired()
            .HasMaxLength(10);
        builder.Property(x=>x.FirstName).IsRequired()
            .HasMaxLength(50);
        builder.Property(x=>x.LastName).IsRequired()
            .HasMaxLength(50);
        builder.Property(x => x.DateCreated)
            .ValueGeneratedOnAdd();
    }
}
