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
                .UseMySql("Server=localhost;Database=bibliotecawf;User ID=root;Password=;Port=3306;", 
                MySqlServerVersion.AutoDetect("Server=localhost;Database=bibliotecawf;User ID=root;Password=;Port=3306;"));
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .Property(l => l.Titulo)
                .IsRequired();
            

        }
    }
}


// PARA CRIAR O BANCO > ADD-MIGRATION > UPDATE-DATABASE