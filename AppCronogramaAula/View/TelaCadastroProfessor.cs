using System;
using System.Windows.Forms;
using AppCronogramaAula.Model;
using AppCronogramaAula.Controller;

namespace CronogramaAula.Views
{
    public partial class TelaCadProf : Form
    {
        public TelaCadProf()
        {
            InitializeComponent();
        }
            private void btnSalvar_Click(object sender, EventArgs e)
            {
                Professor.NomeProf = textBoxNomeProf.Text;
                Professor.EmailProf = textBoxEmailProf.Text;
                Professor.FoneProf = textBoxFoneProf.Text;

                ProfessorController professorController = new ProfessorController();
                professorController.cadastroProfessor();

            textBoxNomeProf.Clear();
            textBoxEmailProf.Clear();
            textBoxFoneProf.Clear();

                if (Professor.Retorno == "True")
                {
                    this.Close();
                }
            }
        }
    }