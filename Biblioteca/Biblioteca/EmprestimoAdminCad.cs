using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class EmprestimoAdminCad : Form
    {
        private Emprestimo emprestimo { get; set; }
        public EmprestimoAdminCad()
        {
            InitializeComponent();
        }

        public EmprestimoAdminCad(Emprestimo emprestimo)
        {
            InitializeComponent();
            this.emprestimo = emprestimo;
        }
    }
}
