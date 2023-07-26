using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogos.model
{
    internal class jogos
    {
        private static string codigo;
        private static string nome;
        private static string genero;
        private static string plataforma;

        public static string Codigo { get => codigo; set => codigo = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Genero { get => genero; set => genero = value; }
        public static string Plataforma { get => plataforma; set => plataforma = value; }
    }
}
