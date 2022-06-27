using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TechnicalChallenge.Models;

namespace TechnicalChallenge.Data
{
    public partial class TechnicalChallengeDbContext : DbContext
    {
        public TechnicalChallengeDbContext()
        {
        }

        public TechnicalChallengeDbContext(DbContextOptions<TechnicalChallengeDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Astronaut> Astronauts { get; set; } = null!;
        public virtual DbSet<AstronomicalObject> AstronomicalObjects { get; set; } = null!;
        public virtual DbSet<Cargo> Cargos { get; set; } = null!;
        public virtual DbSet<Crew> Crews { get; set; } = null!;
        public virtual DbSet<SpaceVehicle> SpaceVehicles { get; set; } = null!;
        public virtual DbSet<SpaceVehicleType> SpaceVehicleTypes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Astronaut>(entity =>
            {
                entity.ToTable("Astronaut");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCrewNavigation)
                    .WithMany(p => p.Astronauts)
                    .HasForeignKey(d => d.IdCrew)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Astronaut_Crew");
            });

            modelBuilder.Entity<AstronomicalObject>(entity =>
            {
                entity.ToTable("AstronomicalObject");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.ToTable("Cargo");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Crew>(entity =>
            {
                entity.ToTable("Crew");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpaceVehicle>(entity =>
            {
                entity.ToTable("SpaceVehicle");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fuel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.SpaceVehicles)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpaceVehicle_Type");
            });

            modelBuilder.Entity<SpaceVehicleType>(entity =>
            {
                entity.ToTable("SpaceVehicleType");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAstronomicalObjectNavigation)
                    .WithMany(p => p.SpaceVehicleTypes)
                    .HasForeignKey(d => d.IdAstronomicalObject)
                    .HasConstraintName("FK_Type_AstronomicalObject");

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.SpaceVehicleTypes)
                    .HasForeignKey(d => d.IdCargo)
                    .HasConstraintName("FK_Type_Cargo");

                entity.HasOne(d => d.IdCrewNavigation)
                    .WithMany(p => p.SpaceVehicleTypes)
                    .HasForeignKey(d => d.IdCrew)
                    .HasConstraintName("FK_Type_Crew");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
