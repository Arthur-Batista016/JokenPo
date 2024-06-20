using CommunityToolkit.Mvvm.ComponentModel;
using JokenPo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JokenPo.ViewModels
{
    internal partial class JokenViewModel:ObservableObject
    {
        [ObservableProperty]
        private string opcaoEscolhida;

        [ObservableProperty]
        private string imagemOponente;

        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private int pontuacaoJogador;

        [ObservableProperty]
        private int pontuacaoOponente;

        private Jogador jogador;
        private Jogador oponente;

        public ICommand FightCommand { get; }

        public JokenViewModel()
        {
            jogador = new Jogador();
            oponente = new Jogador();
            FightCommand = new Command(Fight);
        }

        private void Fight()
        {
            jogador.FazerEscolha(OpcaoEscolhida);
            string opcaoOponente = oponente.Jogar();

            Resultado = DeterminarResultado(jogador.Opcao, opcaoOponente);
            ImagemOponente = oponente.Imagem;

            if (PontuacaoJogador >= 10 || PontuacaoOponente >= 10)
            {
                Resultado += "\n" + (PontuacaoJogador >= 10 ? "Jogador Campeão!" : "Oponente campeão!");
            }
        }

        private string DeterminarResultado(string opcaoJogador, string opcaoOponente)
        {
            if (opcaoJogador == opcaoOponente)
            {
                return "Empate!";
            }
            else if ((opcaoJogador == "rock" && opcaoOponente == "scissor") ||
                     (opcaoJogador == "paper" && opcaoOponente == "rock") ||
                     (opcaoJogador == "scissor" && opcaoOponente == "paper"))
            {
                PontuacaoJogador++;
                return "Jogador venceu!";
               

            }
            else
            {
                PontuacaoOponente++;
                return "Oponente venceu!";
            }
        }
    }
}
