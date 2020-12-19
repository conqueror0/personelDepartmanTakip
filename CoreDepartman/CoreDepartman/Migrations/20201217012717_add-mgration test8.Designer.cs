﻿// <auto-generated />
using System;
using CoreDepartman.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreDepartman.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201217012717_add-mgration test8")]
    partial class addmgrationtest8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreDepartman.Models.departmanlar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("departmanAd");

                    b.HasKey("id");

                    b.ToTable("departmanlars");
                });

            modelBuilder.Entity("CoreDepartman.Models.personal", b =>
                {
                    b.Property<int>("perid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ad");

                    b.Property<int?>("departmanlarid");

                    b.Property<DateTime>("iseGirisTarihi");

                    b.Property<string>("soyad");

                    b.Property<string>("şehir");

                    b.HasKey("perid");

                    b.HasIndex("departmanlarid");

                    b.ToTable("personals");
                });

            modelBuilder.Entity("CoreDepartman.Models.personal", b =>
                {
                    b.HasOne("CoreDepartman.Models.departmanlar", "departmanlar")
                        .WithMany("personals")
                        .HasForeignKey("departmanlarid");
                });
#pragma warning restore 612, 618
        }
    }
}
