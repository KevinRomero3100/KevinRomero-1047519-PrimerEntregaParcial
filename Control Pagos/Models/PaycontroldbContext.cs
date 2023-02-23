using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Control_Pagos.Models;

public partial class PaycontroldbContext : DbContext
{
    public PaycontroldbContext()
    {
    }

    public PaycontroldbContext(DbContextOptions<PaycontroldbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Emplyoee> Emplyoees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=172.28.151.163;userid=kromero;password=kHvilla31;database=paycontroldb;TreatTinyAsBoolean=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.Property(e => e.Dpi).HasColumnName("DPI");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName1).HasMaxLength(255);
            entity.Property(e => e.LastName2).HasMaxLength(255);
            entity.Property(e => e.SecondName).HasMaxLength(255);
        });

        modelBuilder.Entity<Emplyoee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("emplyoee");

            entity.Property(e => e.Dpi).HasColumnName("DPI");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName1).HasMaxLength(255);
            entity.Property(e => e.LastName2).HasMaxLength(255);
            entity.Property(e => e.SecondName).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
