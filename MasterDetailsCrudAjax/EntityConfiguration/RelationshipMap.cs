using MasterDetailsCrudAjax.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterDetailsCrudAjax.EntityConfiguration;

public class RelationshipMap : IEntityTypeConfiguration<Relationship>
{
    public void Configure(EntityTypeBuilder<Relationship> builder)
    {
        builder.ToTable(nameof(Relationship));
        builder.HasKey(x => x.RelationshipId);
        builder.Property(x => x.RelationshipName).IsRequired()
            .HasMaxLength(100);
    }
}
