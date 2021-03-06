﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Receipts.Data.DataBase;

namespace Receipts.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210313193344_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Models.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("Models.Recipe", b =>
                {
                    b.OwnsMany("Models.IngredientRecipe", "Ingredients", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid");

                            b1.Property<DateTime>("CreatedDate")
                                .HasColumnType("timestamp without time zone");

                            b1.Property<string>("Ingredient")
                                .HasColumnType("text");

                            b1.Property<DateTime>("ModifiedDate")
                                .HasColumnType("timestamp without time zone");

                            b1.Property<string>("Quantity")
                                .HasColumnType("text");

                            b1.Property<Guid>("ReceiptId")
                                .HasColumnType("uuid");

                            b1.Property<Guid?>("RecipeId")
                                .HasColumnType("uuid");

                            b1.HasKey("Id");

                            b1.HasIndex("ReceiptId");

                            b1.HasIndex("RecipeId");

                            b1.ToTable("IngredientRecipe");

                            b1.WithOwner()
                                .HasForeignKey("ReceiptId");

                            b1.HasOne("Models.Recipe", "Recipe")
                                .WithMany()
                                .HasForeignKey("RecipeId");

                            b1.Navigation("Recipe");
                        });

                    b.OwnsMany("Models.StepRecipe", "Steps", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid");

                            b1.Property<DateTime>("CreatedDate")
                                .HasColumnType("timestamp without time zone");

                            b1.Property<DateTime>("ModifiedDate")
                                .HasColumnType("timestamp without time zone");

                            b1.Property<Guid>("RecipeId")
                                .HasColumnType("uuid");

                            b1.Property<Guid?>("RecipeId1")
                                .HasColumnType("uuid");

                            b1.Property<string>("Step")
                                .HasColumnType("text");

                            b1.Property<int>("StepNumber")
                                .HasColumnType("integer");

                            b1.HasKey("Id");

                            b1.HasIndex("RecipeId");

                            b1.HasIndex("RecipeId1");

                            b1.ToTable("StepRecipe");

                            b1.WithOwner()
                                .HasForeignKey("RecipeId");

                            b1.HasOne("Models.Recipe", "Recipe")
                                .WithMany()
                                .HasForeignKey("RecipeId1");

                            b1.Navigation("Recipe");
                        });

                    b.Navigation("Ingredients");

                    b.Navigation("Steps");
                });
#pragma warning restore 612, 618
        }
    }
}
