using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Biblioteca
{
    public class Emprestimo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LivroId { get; set; }
        public virtual Livro Livro { get; set; }
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int SituacaoLivro { get; set; } // 0 - Livre,  1 - Emprestimo
    }
}
