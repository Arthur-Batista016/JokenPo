using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo.Models
{
    internal class Jogador
    {
        public string opcaoSorteada { get; set; }

      
        


        public string Jogar()
        {
            return new Random().Next(0, 3) switch
            {
                0 => "pedra",
                1 => "papel",
                2 => "tesoura"
            }; 
        }
    }
}
