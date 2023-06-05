using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace УППО_Пропуски.Models;

public partial class WorkshopControlContext : DbContext
{
    public WorkshopControlContext()
    {
    }

    public WorkshopControlContext(DbContextOptions<WorkshopControlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<Workshop> Workshops { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseLazyLoadingProxies().UseMySql("server=localhost;database=workshop_control;user=root;password=12345", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("division");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(45);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.HasIndex(e => e.Subdivision, "Division_idx");

            entity.HasIndex(e => e.Workshop, "Workshop_idx");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.IsVerificated).HasColumnName("Is_verificated");
            entity.Property(e => e.Name).HasMaxLength(45);
            entity.Property(e => e.Password).HasMaxLength(45);
            entity.Property(e => e.Patronomic).HasMaxLength(45);
            entity.Property(e => e.Photo)
                .HasMaxLength(45)
                .HasDefaultValueSql("'PlaceholderMale.png'");
            entity.Property(e => e.Status).HasColumnType("text");
            entity.Property(e => e.Surname).HasMaxLength(45);

            entity.HasOne(d => d.SubdivisionNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Subdivision)
                .HasConstraintName("Division");

            entity.HasOne(d => d.WorkshopNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Workshop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Workshop");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Datetime).HasName("PRIMARY");

            entity.ToTable("logs");

            entity.HasIndex(e => e.Employee, "Employee1_idx");

            entity.Property(e => e.Datetime).HasColumnType("datetime");
            entity.Property(e => e.Action).HasColumnType("text");

            entity.HasOne(d => d.EmployeeNavigation).WithMany(p => p.Logs)
                .HasForeignKey(d => d.Employee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Employee1");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("request");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Discription).HasColumnType("text");
            entity.Property(e => e.EmployeeMakingRequest).HasColumnName("Employee_making_request");
            entity.Property(e => e.TargetEmployee).HasColumnName("Target_employee");
        });

        modelBuilder.Entity<Workshop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("workshop");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
