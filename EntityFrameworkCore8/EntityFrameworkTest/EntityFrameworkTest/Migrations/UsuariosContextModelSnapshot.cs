﻿// <auto-generated />
using EntityFrameworkTest.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkTest.Migrations
{
    [DbContext(typeof(UsuariosContext))]
    partial class UsuariosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameworkTest.Models.ObraSocial", b =>
                {
                    b.Property<int>("IdObraSocial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdObraSocial"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdObraSocial");

                    b.ToTable("ObraSociales", (string)null);
                });

            modelBuilder.Entity("EntityFrameworkTest.Models.Usuarios", b =>
                {
                    b.Property<int>("IdUsuarios")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuarios"));

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObraSocialId")
                        .HasColumnType("int");

                    b.HasKey("IdUsuarios");

                    b.HasIndex("ObraSocialId");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("EntityFrameworkTest.Models.Usuarios", b =>
                {
                    b.HasOne("EntityFrameworkTest.Models.ObraSocial", "ObraSocial")
                        .WithMany()
                        .HasForeignKey("ObraSocialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ObraSocial");
                });
#pragma warning restore 612, 618
        }
    }
}
