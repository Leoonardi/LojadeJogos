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
            jogos.Codigo = Convert.ToInt32(textBoxcodigo.Text);
            jogos.Nome = txtboxaltnome.Text;
            jogos.Genero = txtboxaltgenero.Text;
            jogos.Plataforma = txtboxaltplataforma.Text;

            gerenciamentodejogos gj = new gerenciamentodejogos();
            gj.alterarjogos();
            

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            jogos.Codigo = Convert.ToInt32(textBox3.Text);

            gerenciamentodejogos mpecas = new gerenciamentodejogos();
            mpecas.pesquisarjogos();

            
            txtboxaltnome.Text = jogos.Nome;
            txtboxaltgenero.Text = jogos.Genero;
            txtboxaltplataforma.Text = jogos.Plataforma;

        }
    }
}
