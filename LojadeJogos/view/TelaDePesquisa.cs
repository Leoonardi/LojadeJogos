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

            jogos.Nome = Convert.ToString(txtboxpesqnome.Text);

            gerenciamentodejogos gj = new gerenciamentodejogos();
            gj.pesquisarjogos();

            txtboxpesqnome.Text = jogos.Nome.ToString();
            txtboxpesqgenero.Text = jogos.Genero;
            txtboxpesqplataforma.Text = jogos.Plataforma;


           
        }
    }
}
