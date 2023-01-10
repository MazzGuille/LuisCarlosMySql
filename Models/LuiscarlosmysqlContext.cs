using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LuisCarlosMySql.Models;

public partial class LuiscarlosmysqlContext : DbContext
{
    public LuiscarlosmysqlContext()
    {
    }

    public LuiscarlosmysqlContext(DbContextOptions<LuiscarlosmysqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProductos).HasName("PRIMARY");

            entity.ToTable("productos");

            entity.Property(e => e.IdProductos).HasColumnName("idProductos");
            entity.Property(e => e.Marca).HasMaxLength(45);
            entity.Property(e => e.Modelo).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
