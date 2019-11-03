﻿// <auto-generated />
using System;
using KetoCalculator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KetoCalculator.Migrations
{
    [DbContext(typeof(KetoCalcContext))]
    [Migration("20191103191747_dbmigrate")]
    partial class dbmigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KetoCalculator.Models.AspNetRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetRoles", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetUsers", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("KetoCalculator.Models.DayRecipeFood", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .HasColumnName("RecipeID");

                    b.Property<Guid>("FoodId")
                        .HasColumnName("FoodID");

                    b.Property<DateTime>("RecipeDate")
                        .HasColumnType("date");

                    b.Property<decimal>("Grams")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2(0)");

                    b.HasKey("RecipeId", "FoodId", "RecipeDate");

                    b.ToTable("DayRecipeFood");
                });

            modelBuilder.Entity("KetoCalculator.Models.DayRecipes", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .HasColumnName("RecipeID");

                    b.Property<DateTime>("RecipeDate")
                        .HasColumnType("date");

                    b.Property<decimal>("Calories")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Ratio")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("RecipieUser");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2(0)");

                    b.HasKey("RecipeId", "RecipeDate");

                    b.ToTable("DayRecipes");
                });

            modelBuilder.Entity("KetoCalculator.Models.FoodGroup", b =>
                {
                    b.Property<Guid>("FoodGroupId")
                        .HasColumnName("FoodGroupID");

                    b.Property<string>("FoodGroupName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("UpdateDatetime")
                        .HasColumnType("datetime2(0)");

                    b.HasKey("FoodGroupId");

                    b.ToTable("FoodGroup");
                });

            modelBuilder.Entity("KetoCalculator.Models.FoodStuff", b =>
                {
                    b.Property<Guid>("FoodId")
                        .HasColumnName("FoodID");

                    b.Property<decimal>("CarbPer100")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<decimal>("FatPer100")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<Guid>("FoodGroupId")
                        .HasColumnName("FoodGroupID");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("ProteinPer100")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2(0)");

                    b.HasKey("FoodId");

                    b.HasIndex("FoodGroupId");

                    b.ToTable("FoodStuff");
                });

            modelBuilder.Entity("KetoCalculator.Models.RecipeFood", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .HasColumnName("RecipeID");

                    b.Property<Guid>("FoodId")
                        .HasColumnName("FoodID");

                    b.Property<decimal>("Grams")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2(0)");

                    b.HasKey("RecipeId", "FoodId");

                    b.HasIndex("FoodId");

                    b.ToTable("RecipeFood");
                });

            modelBuilder.Entity("KetoCalculator.Models.Recipes", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .HasColumnName("RecipeID");

                    b.Property<decimal>("Calories")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Ratio")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid?>("RecipieUser");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2(0)");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetRoleClaims", b =>
                {
                    b.HasOne("KetoCalculator.Models.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetUserClaims", b =>
                {
                    b.HasOne("KetoCalculator.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetUserLogins", b =>
                {
                    b.HasOne("KetoCalculator.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetUserRoles", b =>
                {
                    b.HasOne("KetoCalculator.Models.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KetoCalculator.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KetoCalculator.Models.AspNetUserTokens", b =>
                {
                    b.HasOne("KetoCalculator.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KetoCalculator.Models.FoodStuff", b =>
                {
                    b.HasOne("KetoCalculator.Models.FoodGroup", "FoodGroup")
                        .WithMany("FoodStuff")
                        .HasForeignKey("FoodGroupId")
                        .HasConstraintName("FK_FoodStuff_FoodGroup");
                });

            modelBuilder.Entity("KetoCalculator.Models.RecipeFood", b =>
                {
                    b.HasOne("KetoCalculator.Models.FoodStuff", "Food")
                        .WithMany("RecipeFood")
                        .HasForeignKey("FoodId")
                        .HasConstraintName("FK_RecipeFood_FoodStuff");

                    b.HasOne("KetoCalculator.Models.Recipes", "Recipe")
                        .WithMany("RecipeFood")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK_RecipeFood_Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}