using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace KetoCalculator.Models
{
    public partial class KetoCalcContext : DbContext
    {
        public KetoCalcContext()
        {
        }

        public KetoCalcContext(DbContextOptions<KetoCalcContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DayRecipeFood> DayRecipeFood { get; set; }
        public virtual DbSet<DayRecipes> DayRecipes { get; set; }
        public virtual DbSet<FoodGroup> FoodGroup { get; set; }
        public virtual DbSet<FoodStuff> FoodStuff { get; set; }
        public virtual DbSet<RecipeFood> RecipeFood { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }
        public virtual DbSet<UserGoals> UserGoals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(projectPath)
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Surname).IsRequired();

            });

            modelBuilder.Entity<DayRecipeFood>(entity =>
            {
                entity.HasKey(e => new { e.RecipeId, e.FoodId, e.RecipeDate });

                entity.Property(e => e.RecipeId).HasColumnName("RecipeID");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.RecipeDate).HasColumnType("date");

                entity.Property(e => e.Grams).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.DayRecipeFood)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DayRecipeFood_FoodStuff");

                entity.HasOne(d => d.DayRecipe)
                    .WithMany(p => p.DayRecipeFood)
                    .HasForeignKey(d => new { d.RecipeId, d.RecipeDate })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DayRecipeFood_DayRecipes");
            });

            modelBuilder.Entity<DayRecipes>(entity =>
            {
                entity.HasKey(e => new { e.RecipeId, e.RecipeDate });

                entity.Property(e => e.RecipeId).HasColumnName("RecipeID");

                entity.Property(e => e.RecipeDate).HasColumnType("date");

                entity.Property(e => e.Calories).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RecipeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<FoodGroup>(entity =>
            {
                entity.Property(e => e.FoodGroupId)
                    .HasColumnName("FoodGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FoodGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDatetime).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<FoodStuff>(entity =>
            {
                entity.HasKey(e => e.FoodId);

                entity.HasIndex(e => e.FoodGroupId);

                entity.Property(e => e.FoodId)
                    .HasColumnName("FoodID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarbPer100).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FatPer100).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FoodGroupId).HasColumnName("FoodGroupID");

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProteinPer100).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.FoodGroup)
                    .WithMany(p => p.FoodStuff)
                    .HasForeignKey(d => d.FoodGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FoodStuff_FoodGroup");
            });

            modelBuilder.Entity<RecipeFood>(entity =>
            {
                entity.HasKey(e => new { e.RecipeId, e.FoodId });

                entity.HasIndex(e => e.FoodId);

                entity.Property(e => e.RecipeId).HasColumnName("RecipeID");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.Grams).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.RecipeFood)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecipeFood_FoodStuff");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeFood)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecipeFood_Recipes");
            });

            modelBuilder.Entity<Recipes>(entity =>
            {
                entity.HasKey(e => e.RecipeId);

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RecipeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Calories).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RecipeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<UserGoals>(entity =>
            {
                entity.HasKey(e => e.GoalId);

                entity.Property(e => e.GoalId)
                    .HasColumnName("GoalID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GoalCalories).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GoalDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.GoalRatio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);
            });
        }
    
    }
}