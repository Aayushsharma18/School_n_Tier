using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using School_DataAccess.Models;

namespace School_Modles.Models;
#nullable disable
public partial class SchoolContext : DbContext
{
    public SchoolContext()
    {
    }

    public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options)
    {
    }

    // public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
    public virtual DbSet<Grade> Grades { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-GE1A8GO;Database=School;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<MigrationHistory>(entity =>
        // {
        //     entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

        //     entity.ToTable("__MigrationHistory");

        //     entity.Property(e => e.MigrationId).HasMaxLength(150);
        //     entity.Property(e => e.ContextKey).HasMaxLength(300);
        //     entity.Property(e => e.ProductVersion).HasMaxLength(32);
        // });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Grades");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Students");

            entity.HasIndex(e => e.GradeId, "IX_Grade_Id");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.GradeId).HasColumnName("Grade_Id");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Weight).HasColumnName("Weight");
            entity.Property(e => e.TeacherId).HasColumnName("Teacher_Id");


            entity.HasOne(d => d.Grade)
                .WithMany(p => p.Students)
                .HasForeignKey(d => d.GradeId)
                .HasConstraintName("FK_dbo.Students_dbo.Grades_Grade_Id1");

            entity.HasOne(d => d.Teacher)
                .WithMany(p => p.Students)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_dbo.Students_dbo.Teachers_Teacher_Id1");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Teachers");

            entity.Property(e => e.Id);
            entity.Property(e => e.Name);
            entity.Property(e => e.DateOfBirth);
            entity.Property(e => e.Phone);

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
