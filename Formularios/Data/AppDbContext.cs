using Formularios.Models;
using Microsoft.EntityFrameworkCore;

namespace Formularios.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Aluno> Alunos { get; set; }
}