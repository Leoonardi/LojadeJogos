using LojadeJogos.controller;
using LojadeJogos.model;
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
    public partial class TelaDeletarJogos : Form
    {
        public TelaDeletarJogos()
        {
            InitializeComponent();
        }

      

        private void btndeletar_Click(object sender, EventArgs e)
        {
            jogos.Nome = Convert.ToString(txtboxexclunome.Text);

            gerenciamentodejogos gj = new gerenciamentodejogos();
            gj.deletarJogos();
        }

        public void abrirDeletar()
        {
            this.ShowDialog();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            jogos.Nome = Convert.ToString(txtboxexclunome.Text);

            gerenciamentodejogos gj = new gerenciamentodejogos();
            gj.deletarJogos();
        }
    }
}
