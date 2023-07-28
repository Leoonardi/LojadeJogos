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
    public partial class TelaDePesquisa : Form
    {
        public TelaDePesquisa()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            jogos.Codigo = Convert.ToInt32(textboxcod.Text);

            gerenciamentodejogos mpecas = new gerenciamentodejogos();
            mpecas.pesquisarjogos();

            textboxcod.Text = jogos.Codigo.ToString();
            txtboxpesqnome.Text = jogos.Nome;
            txtboxpesqgenero.Text = jogos.Genero;
            txtboxpesqplataforma.Text = jogos.Plataforma;
        }

        private void textboxcod_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
