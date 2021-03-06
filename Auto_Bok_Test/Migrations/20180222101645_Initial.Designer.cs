﻿// <auto-generated />
using Auto_Bok_Test.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Auto_Bok_Test.Migrations
{
    [DbContext(typeof(Auto_Bok_TestContext))]
    [Migration("20180222101645_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Auto_Bok_Test.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("EmployedSince");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Position");

                    b.HasKey("ID");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
