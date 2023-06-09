﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pandape.Infrastructure.Persistence.DataBase;

namespace Pandape.Infrastructure.Migrations
{
    [DbContext(typeof(PandapeContext))]
    [Migration("20230324185954_AddRequiredAttribute")]
    partial class AddRequiredAttribute
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pandape.Domain.Entities.Candidate", b =>
                {
                    b.Property<int>("IdCandidate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("IdCandidate");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            IdCandidate = 1,
                            BirthDate = new DateTime(1982, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alejandro@gmail.com",
                            InsertDate = new DateTime(2023, 3, 24, 18, 59, 53, 947, DateTimeKind.Local).AddTicks(3176),
                            Name = "Alejandro",
                            SurName = "Montu"
                        },
                        new
                        {
                            IdCandidate = 2,
                            BirthDate = new DateTime(1974, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jorge@gmail.com",
                            InsertDate = new DateTime(2023, 3, 24, 18, 59, 53, 950, DateTimeKind.Local).AddTicks(157),
                            Name = "Jorge",
                            SurName = "Gallardo"
                        });
                });

            modelBuilder.Entity("Pandape.Domain.Entities.CandidateExperience", b =>
                {
                    b.Property<int>("IdCandidateExperience")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CandidateIdCandidate")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(4000)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCandidate")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("IdCandidateExperience");

                    b.HasIndex("CandidateIdCandidate");

                    b.ToTable("CandidateExperiences");
                });

            modelBuilder.Entity("Pandape.Domain.Entities.CandidateExperience", b =>
                {
                    b.HasOne("Pandape.Domain.Entities.Candidate", null)
                        .WithMany("CandidateExperiences")
                        .HasForeignKey("CandidateIdCandidate");
                });
#pragma warning restore 612, 618
        }
    }
}
