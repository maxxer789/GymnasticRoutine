﻿// <auto-generated />
using DataAcces.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAcces.Migrations.Element
{
    [DbContext(typeof(ElementContext))]
    partial class ElementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAcces.DTOs.ApparatusDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abbreviation")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("ApparatusDTO");
                });

            modelBuilder.Entity("DataAcces.DTOs.ElementDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Difficulty")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("SkillGroupId")
                        .HasColumnType("int");

                    b.Property<decimal>("Worth")
                        .HasColumnType("decimal(1,1)");

                    b.HasKey("Id");

                    b.HasIndex("SkillGroupId");

                    b.ToTable("Element");
                });

            modelBuilder.Entity("DataAcces.DTOs.SkillGroupDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApparatusId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ApparatusId");

                    b.ToTable("SkillGroupDTO");
                });

            modelBuilder.Entity("DataAcces.DTOs.ElementDTO", b =>
                {
                    b.HasOne("DataAcces.DTOs.SkillGroupDTO", "SkillGroup")
                        .WithMany("Elements")
                        .HasForeignKey("SkillGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAcces.DTOs.SkillGroupDTO", b =>
                {
                    b.HasOne("DataAcces.DTOs.ApparatusDTO", "Apparatus")
                        .WithMany("SkillGroups")
                        .HasForeignKey("ApparatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
