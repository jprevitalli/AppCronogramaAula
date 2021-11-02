using System;
using System.Windows.Forms;
using AppCronogramaAula.Model;
using AppCronogramaAula.Controller;

namespace CronogramaAula
{
    public partial class TelaCadSala : Form
    {
        public TelaCadSala()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Sala.NomeSala = textBoxNomeSala.Text;
            Sala.TipoSala = textBoxTipoSala.Text; 


            SalaController salaController = new SalaController();
            salaController.cadastroSala();

            textBoxNomeSala.Clear();
            


            if (Sala.Retorno == "True")
            {
                this.Close();
            }
        }
    }
}