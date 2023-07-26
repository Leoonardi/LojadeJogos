using LojadeJogos.controller;
using LojadeJogos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogos.view
{
    public partial class TelaAlterarJogos : Form
    {
        public TelaAlterarJogos()
        {
            InitializeComponent();
        }

       

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            jogos.Nome = Convert.ToString(txtboxaltnome.Text);

            txtboxaltnome.Text = jogos.Nome.ToString();
            txtboxaltgenero.Text = jogos.Genero;
            txtboxaltplataforma.Text = jogos.Plataforma;

            gerenciamentodejogos gj = new gerenciamentodejogos();
            gj.pesquisarjogos();

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            jogos.Nome = Convert.ToString(txtboxaltnome.Text);

            txtboxaltnome.Text = jogos.Nome.ToString();
            txtboxaltgenero.Text = jogos.Genero;
            txtboxaltplataforma.Text = jogos.Plataforma;

            gerenciamentodejogos gj = new gerenciamentodejogos();
            gj.pesquisarjogos();
        }
    }
}
