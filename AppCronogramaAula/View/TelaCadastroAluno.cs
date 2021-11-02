using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCronogramaAula.Model;
using AppCronogramaAula.Controller;


namespace AppCronogramaAula.View
{
    public partial class TelaCadastroAluno : Form
    {
        public TelaCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno.NomeAluno = textBoxNome.Text;
            Aluno.EmailAluno = textBoxEmail.Text;
            Aluno.FoneAluno = textBoxFone.Text;

            AlunoController alunoController = new AlunoController();
            alunoController.cadastroAluno();
        }
    }
}
