using LojadeJogos.controller;
using LojadeJogos.model;
using LojadeJogos.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            gerenciamentodejogos gj = new gerenciamentodejogos();
            gj.deletarJogos();

            jogos.Codigo = Convert.ToInt32(textboxcod.Text);

            gerenciamentodejogos mpecas = new gerenciamentodejogos();
            mpecas.deletarJogos();



        }



        private void btnpesquisar_Click(object sender, EventArgs e)
        {


            jogos.Codigo = Convert.ToInt32(textboxcod.Text);

            gerenciamentodejogos mpecas = new gerenciamentodejogos();
            mpecas.pesquisarjogos();

            textboxcod.Text = jogos.Codigo.ToString();
            txtboxpesqnome.Text = jogos.Nome;
            txtboxpesqgenero.Text = jogos.Genero;
            txtboxpesqplataforma.Text = jogos.Plataforma;

           MessageBox.Show("Jogo não encontrado");


        }

        public void abrirDeletar()
        {
            this.ShowDialog();
        }
    }
    
}


