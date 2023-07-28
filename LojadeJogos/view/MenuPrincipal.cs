using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogos.view
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

       

        

        private void cadastrarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarJogos telaCadastrar = new TelaCadastrarJogos();
            telaCadastrar.Show();
        }

        private void buscarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDePesquisa dePesquisa = new TelaDePesquisa();
            dePesquisa.Show();
        }

        private void alterarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarJogos telaAlterar = new TelaAlterarJogos();
            telaAlterar.Show();
        }

        private void deletarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeletarJogos deletarJogos = new TelaDeletarJogos();
            deletarJogos.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gerenciamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
