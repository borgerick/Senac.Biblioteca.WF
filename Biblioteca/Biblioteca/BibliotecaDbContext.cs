using Microsoft.EntityFrameworkCore;

namespace Biblioteca
{
    public class BibliotecaDbContext: DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // use mysql as database
            optionsBuilder
                .UseMySql("server=localhost;database=bibliotecawf;user=root;password=", 
                MySqlServerVersion.AutoDetect("server=localhost;database=bibliotecawf;user=root;password="));
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .Property(l => l.Titulo)
                .IsRequired();
            

        }
    }
}
