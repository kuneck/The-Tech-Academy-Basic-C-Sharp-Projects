using Microsoft.EntityFrameworkCore;

public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configuração do banco de dados (Substitua o valor da string de conexão conforme necessário)
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentDatabase;Trusted_Connection=True;");
    }
}
