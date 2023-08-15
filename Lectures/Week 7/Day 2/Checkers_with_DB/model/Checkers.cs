using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CheckersGame.Model;

public partial class Checkers : DbContext
{
    public Checkers()
    {
    }

    public Checkers(DbContextOptions<Checkers> options)
        : base(options)
    {
    }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Piece> Pieces { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Rank> Ranks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Filename=Checkers.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<Piece>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.IsEaten).HasDefaultValueSql("0");
            entity.Property(e => e.IsKinged).HasDefaultValueSql("0");

            entity.HasOne(d => d.Color).WithMany(p => p.Pieces).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Position).WithMany(p => p.Pieces).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Rank).WithMany(p => p.Pieces).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<Rank>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
