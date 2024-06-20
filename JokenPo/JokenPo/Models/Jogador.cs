
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo.Models
{
    internal class Jogador
    {
        public string Imagem { get; set; }
        public string Opcao { get; set; }
        public int Pontuacao { get; set; }

        public Jogador()
        {
            Pontuacao = 0;
        }

        public void FazerEscolha(string opcao)
        {
            Opcao = opcao;
            Imagem = $"{opcao}.jpg";
        }

        public string Jogar()
        {
            string[] opcoes = { "rock", "paper", "scissor" };
            Random random = new Random();
            Opcao = opcoes[random.Next(opcoes.Length)];
            Imagem = $"{Opcao}.jpg";
            return Opcao;
        }
    }
}
