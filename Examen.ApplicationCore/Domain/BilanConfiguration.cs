using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Examen.ApplicationCore.Domain;

public class BilanConfiguration : IEntityTypeConfiguration<Bilan>
{
    public void Configure(EntityTypeBuilder<Bilan> builder)
    {
        // Clé primaire composée
        builder.HasKey(b => new { b.CodeInfirmier, b.CodePatient, b.DatePrelevement });

        // Relations
        builder.HasOne(b => b.Infirmier)
               .WithMany(i => i.Bilans)
               .HasForeignKey(b => b.CodeInfirmier);

        builder.HasOne(b => b.Patient)
               .WithMany(p => p.Bilans)
               .HasForeignKey(b => b.CodePatient);
    }
}
