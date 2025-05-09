﻿// <auto-generated />
using System;
using Examen.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Analyse", b =>
                {
                    b.Property<int>("AnalyseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnalyseId"));

                    b.Property<int>("DureeResultat")
                        .HasColumnType("int");

                    b.Property<double>("PrixAnalyse")
                        .HasColumnType("float");

                    b.Property<string>("TypeAnalyse")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("ValeurAnalyse")
                        .HasColumnType("real")
                        .HasColumnName("Valeur/analyse");

                    b.Property<float>("ValeurMaxNormale")
                        .HasColumnType("real")
                        .HasColumnName("ValeurMaxNormale");

                    b.Property<float>("ValeurMinNormale")
                        .HasColumnType("real")
                        .HasColumnName("ValeurMinNormale");

                    b.HasKey("AnalyseId");

                    b.ToTable("Analyses");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Bilan", b =>
                {
                    b.Property<int>("CodeInfirmier")
                        .HasColumnType("int");

                    b.Property<int>("CodePatient")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePrelevement")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailMedecin")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Paye")
                        .HasColumnType("bit");

                    b.HasKey("CodeInfirmier", "CodePatient", "DatePrelevement");

                    b.HasIndex("CodePatient");

                    b.ToTable("Bilans");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Infirmier", b =>
                {
                    b.Property<int>("InfirmierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InfirmierId"));

                    b.Property<string>("NonComplet")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Specialite")
                        .HasColumnType("int");

                    b.HasKey("InfirmierId");

                    b.ToTable("Infirmiers");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Laboratoire", b =>
                {
                    b.Property<int>("LaboratoireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LaboratoireId"));

                    b.Property<string>("Intitule")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Localisation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("AdresseLabo");

                    b.HasKey("LaboratoireId");

                    b.ToTable("Laboratoires");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Patient", b =>
                {
                    b.Property<int>("CodePatient")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodePatient"));

                    b.Property<string>("EmailPatient")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Informations")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nomcomplet")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Numerotel")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CodePatient");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Bilan", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Infirmier", "Infirmier")
                        .WithMany("Bilans")
                        .HasForeignKey("CodeInfirmier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domain.Patient", "Patient")
                        .WithMany("Bilans")
                        .HasForeignKey("CodePatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Infirmier");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Infirmier", b =>
                {
                    b.Navigation("Bilans");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Patient", b =>
                {
                    b.Navigation("Bilans");
                });
#pragma warning restore 612, 618
        }
    }
}
