using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyProject.MODEL;

namespace MyProject.DAL.DBContext;

public partial class DBibliotecarevisaoMyprojectDalDatabaseDatabase1MdfContext : DbContext
{
    public DBibliotecarevisaoMyprojectDalDatabaseDatabase1MdfContext()
    {
    }

    public DBibliotecarevisaoMyprojectDalDatabaseDatabase1MdfContext(DbContextOptions<DBibliotecarevisaoMyprojectDalDatabaseDatabase1MdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Livro> Livros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\BibliotecaRevisao\\MyProject.DAL\\database\\Database1.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Livro__3214EC07B3233E98");

            entity.ToTable("Livro");

            entity.Property(e => e.Ano)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Editora)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Resumo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
