﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetOuististiEntityFramework;

#nullable disable

namespace ProjetOuististiEntityFramework.Migrations
{
    [DbContext(typeof(ProjetOuististiDbContext))]
    [Migration("20230103143240_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("ProjetOuististiDomain.Calcul.CalculAbstract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Input1")
                        .HasColumnType("REAL");

                    b.Property<float>("Input2")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Calculs");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CalculAbstract");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ProjetOuististiDomain.Calcul.CalculAddition", b =>
                {
                    b.HasBaseType("ProjetOuististiDomain.Calcul.CalculAbstract");

                    b.HasDiscriminator().HasValue("CalculAddition");
                });

            modelBuilder.Entity("ProjetOuististiDomain.Calcul.CalculDivision", b =>
                {
                    b.HasBaseType("ProjetOuististiDomain.Calcul.CalculAbstract");

                    b.HasDiscriminator().HasValue("CalculDivision");
                });

            modelBuilder.Entity("ProjetOuististiDomain.Calcul.CalculMultiplication", b =>
                {
                    b.HasBaseType("ProjetOuististiDomain.Calcul.CalculAbstract");

                    b.HasDiscriminator().HasValue("CalculMultiplication");
                });

            modelBuilder.Entity("ProjetOuististiDomain.Calcul.CalculSoustraction", b =>
                {
                    b.HasBaseType("ProjetOuististiDomain.Calcul.CalculAbstract");

                    b.HasDiscriminator().HasValue("CalculSoustraction");
                });
#pragma warning restore 612, 618
        }
    }
}
