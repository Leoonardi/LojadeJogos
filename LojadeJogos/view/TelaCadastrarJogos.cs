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
    public partial class TelaCadastrarJogos : Form
    {
        public TelaCadastrarJogos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            jogos.Nome = txtboxcadasnome.Text;
            jogos.Genero = txtboxcadasgenero.Text;
            jogos.Plataforma = txtboxcadasplataforma.Text;

            gerenciamentodejogos gj = new gerenciamentodejogos();

            gj.jogoscadas();

        }
        public void abrirCadastro()
        {
            this.ShowDialog();
        } 
    }
}
