using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogos.model
{
    internal class conexao
    {
        public static string conectar()
        {
          return  @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matheus.fleonardi\source\repos\LojadeJogos\LojadeJogos\model\lojadejogosbd.mdf;Integrated Security=True";
        }
    }
}
