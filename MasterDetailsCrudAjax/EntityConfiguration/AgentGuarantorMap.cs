using MasterDetailsCrudAjax.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterDetailsCrudAjax.EntityConfiguration;

public class AgentGuarantorMap : IEntityTypeConfiguration<AgentGuarantor>
{
    public void Configure(EntityTypeBuilder<AgentGuarantor> builder)
    {
        builder.ToTable(nameof(AgentGuarantor));
        builder.HasKey(x => x.AgentGuarantorId);
        builder.Property(x => x.FirstName).IsRequired()
            .HasMaxLength(50);
        builder.Property(x => x.LastName).IsRequired()
            .HasMaxLength(50);
    }
}
