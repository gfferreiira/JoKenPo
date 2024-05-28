using Jokenpo.Model.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Model
{
    public class Jogador
    {

        public string Nome { get; set; }

        public EscolhaEnum Escolha {  get; set; }

        public int Pontuacao { get; set; }

        

        public Jogador(string nome) 
        {
            Nome = nome;
            
        }

        public int Jogar()
        {
            return new Random().Next(1, 4);
        }

    }
}
