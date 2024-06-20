using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Graphics.Paint;
using System.Windows.Input;

namespace JokenPo.ViewModels
{
    internal class JokenViewModel:ObservableObject
    {
        [ObservableProperty]
        private string _escolha;
        [ObservableProperty]
        public String _opcaoEscolhida;

        [ObservableProperty]
        public String _imagem;

        [ObservableProperty]
        public String _resultado;

       public ICommand fightCommand { get; private set; }

        public JokenViewModel()
        {
            fightCommand = new Command(fight);
        }

        public void fight()
        {
            Jogador jogador1 = new Jogador();
            Resultado = Jogar(LadoEscolhido);
            //Pegar o resultado da Moeda e escrever na label
            Imagem = $"{jogador._imagem}.png";
        }

    }
}
