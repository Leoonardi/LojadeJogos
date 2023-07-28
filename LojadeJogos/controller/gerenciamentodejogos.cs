using LojadeJogos.model;
using LojadeJogos.view;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LojadeJogos.controller
{
    internal class gerenciamentodejogos
    {


        public void jogoscadas()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand gdj = new SqlCommand("pcadastrarJogos", cn);
            gdj.CommandType = CommandType.StoredProcedure;

            try
            {
                gdj.Parameters.AddWithValue("nome", jogos.Nome);
                gdj.Parameters.AddWithValue("genero", jogos.Genero);
                gdj.Parameters.AddWithValue("plataforma", jogos.Plataforma);

                SqlParameter jj = gdj.Parameters.Add("Idjogos", SqlDbType.Int);
                jj.Direction = ParameterDirection.Output;
                cn.Open();
                gdj.ExecuteNonQuery();

                var resposta = MessageBox.Show("Novo Jogo cadastrado com sucesso!, Deseja cadastrar um novo?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaCadastrarJogos telaCadastrar = new TelaCadastrarJogos();
                    telaCadastrar.abrirCadastro();

                }

            }
            catch (Exception)
            {

                throw;
            }








        }

        public void deletarJogos()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand gdj = new SqlCommand("pDeletarJogos", cn);
            gdj.CommandType = CommandType.StoredProcedure;

            try
            {
                gdj.Parameters.AddWithValue("idjogos", jogos.Codigo);
                cn.Open();
                gdj.ExecuteNonQuery();

                var resposta = MessageBox.Show("Jogo deletado com sucesso!,deseja apagar outro jogo? ", "Deletar dados",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

               

                if (resposta == DialogResult.Yes)
                {
                    TelaDeletarJogos telaDeletar = new TelaDeletarJogos();
                    telaDeletar.abrirDeletar();
                }

                else
                {
                    return;
                }



            }
            catch (Exception)
            {

                throw;
            }



        }

        public void alterarjogos()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand gdj = new SqlCommand("pAlterarJogos", cn);
            gdj.CommandType = CommandType.StoredProcedure;

            try
            {
                gdj.Parameters.AddWithValue("idjogos", jogos.Codigo);
                gdj.Parameters.AddWithValue("nome", jogos.Nome);
                gdj.Parameters.AddWithValue("genero", jogos.Genero);
                gdj.Parameters.AddWithValue("plataforma", jogos.Plataforma);

                cn.Open();
                gdj.ExecuteNonQuery();

                MessageBox.Show("Jogo alterado com sucesso");
                jogos.Nome = "";
                jogos.Genero = "";
                jogos.Plataforma = "";

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void pesquisarjogos()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand gdj = new SqlCommand("pBuscaJogos", cn);
            gdj.CommandType = CommandType.StoredProcedure;

            try
            {
                gdj.Parameters.AddWithValue("@idjogos", jogos.Codigo);
                cn.Open();

                var registro = gdj.ExecuteReader();

                if (registro.Read())
                {
                    jogos.Codigo = Convert.ToInt32(registro["idjogos"]);
                    jogos.Nome = (string)registro["nome"];
                    jogos.Genero = (string)registro["genero"];
                    jogos.Plataforma = (string)registro["plataforma"];



                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        public static BindingSource PesquisarNome()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand gdj = new SqlCommand("pBuscaJogosnome", cn);
            gdj.CommandType = CommandType.StoredProcedure;
            gdj.Parameters.AddWithValue("@nome", jogos.Nome);
            cn.Open();
            gdj.ExecuteNonQuery();



            SqlDataAdapter da = new SqlDataAdapter(gdj);
            DataTable dt = new DataTable();

            da.Fill(dt);

            BindingSource dados = new BindingSource();
            dados.DataSource = dt;

            return dados;
        }

    }


    }
















