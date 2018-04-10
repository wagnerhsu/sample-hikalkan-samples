﻿// <auto-generated />
using System;
using EfCoreCollectionBugRepro.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace EfCoreCollectionBugRepro.Migrations
{
    [DbContext(typeof(PersonDbContext))]
    [Migration("20180410124203_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview1-28290")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfCoreCollectionBugRepro.Entities.ChangeLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChangeInfo");

                    b.Property<Guid>("PersonId");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("ChangeLog");
                });

            modelBuilder.Entity("EfCoreCollectionBugRepro.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("EfCoreCollectionBugRepro.Entities.ChangeLog", b =>
                {
                    b.HasOne("EfCoreCollectionBugRepro.Entities.Person")
                        .WithMany("ChangeLogs")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
