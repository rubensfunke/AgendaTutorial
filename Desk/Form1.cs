using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk
{
    public partial class label1 : Form
    {
        public label1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            p.Email = txtEmail.Text;
            p.Idade = Convert.ToInt32(txtIdade.Text);
            p.Nome  = txtNome.Text;

            if (!pnAgenda.Inserir(p))
            {
                MessageBox.Show("Algo deu errado!!!");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            
            p.pnAgenda.Pesquisar(txtEmail.Text);

            if(p != null)
            {
                txtEmail.Text = p.Email;
                txtIdade.Text = p.Idade.ToString();
                txtNome.Text = p.Nome;
            }
            else
            {
                MessageBox.Show("Este E-mail não existe!!!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            p.Email = txtEmail.Text;
            p.Idade = Convert.ToInt32(txtIdade.Text);
            p.Nome = txtNome.Text;

            if(MessageBox.Show("Confimra Exclusão?", "Atençao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pnAgenda.Excluir(p);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            p.Email = txtEmail.Text;
            p.Idade = Convert.ToInt32(txtIdade.Text);
            p.Nome = txtNome.Text;

            if (!pnAgenda.Alterar(p))
            {
                MessageBox.Show("Algo deu errado na alteração!!!");
            }
        }
    }
}
