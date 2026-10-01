using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nttd2410900020_exam.Models;

public partial class Nttd2410900020ExamDpContext : DbContext
{
    public Nttd2410900020ExamDpContext()
    {
    }

    public Nttd2410900020ExamDpContext(DbContextOptions<Nttd2410900020ExamDpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NttdEmployee> NttdEmployees { get; set; }

    public virtual DbSet<NttdEmployee1> NttdEmployees1 { get; set; }

    public virtual DbSet<NttdStudent> NttdStudents { get; set; }

    public virtual DbSet<NttdStudent> Nttdtudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS01;Database=Nttd2410900020ExamDp;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NttdEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NttdEmpl__3214EC07E898D73B");

            entity.ToTable("NttdEmployee");

            entity.Property(e => e.NttdEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NttdName).HasMaxLength(100);
            entity.Property(e => e.NttdPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NttdEmployee1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NttdEmpl__3214EC0753B82472");

            entity.ToTable("NttdEmployees");

            entity.Property(e => e.NttdEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NttdName).HasMaxLength(100);
            entity.Property(e => e.NttdPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NttdStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NttdStud__3214EC07A4844269");

            entity.ToTable("NttdStudent");

            entity.Property(e => e.NttdEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NttdName).HasMaxLength(100);
            entity.Property(e => e.NttdPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NttdStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Nttdtude__3214EC071A282383");

            entity.ToTable("Nttdtudent");

            entity.Property(e => e.NttdEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NttdName).HasMaxLength(100);
            entity.Property(e => e.NttdPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
