﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WEB315_Summer23_ThemePunjabiCulture.Migrations
{
    [DbContext(typeof(PunjabiCultureContext))]
    [Migration("20230209223454_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("WEB315_Summer23_ThemePunjabiCulture.Models.PunjabiCulture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Costume")
                        .HasColumnType("TEXT");

                    b.Property<string>("CultureName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Food")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OccassionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganisedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("PunjabiCulture");
                });
#pragma warning restore 612, 618
        }
    }
}
