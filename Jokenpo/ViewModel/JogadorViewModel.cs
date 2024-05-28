
using CommunityToolkit.Mvvm.ComponentModel;
using Jokenpo.Model;
using Jokenpo.Model.Enum;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Jokenpo.ViewModel
{
    public partial class JogadorViewModel : ObservableObject
    {

       

        [ObservableProperty]
        private string _nome;

        [ObservableProperty]
        private EscolhaEnum _escolha;

        [ObservableProperty]
        private int _pontuacao;

        [ObservableProperty]
        private Jogador _jogador;

        [ObservableProperty]
        private Jogador _maquina;

        [ObservableProperty]
        private string _resultado;
        [ObservableProperty]
        private string _enemyImage;

        [ObservableProperty]
        private string _playerImage;



        public ICommand PlayCommand { get; }

        public JogadorViewModel()
        {
           
            Jogador = new Jogador(Nome);
            Maquina = new Jogador("Maquina");
            PlayCommand = new Command(Play);
        }


        public void Play()
        {
            Jogador.Nome = Nome;
            Jogador.Escolha = Escolha;
            Maquina.Escolha = (EscolhaEnum)new Random().Next(1, 4);
            EnemyImage = $"{Maquina.Escolha}.png";
            PlayerImage = $"{Jogador.Escolha}.png";
            DeterminarVencedor();
            Pontuacao = Jogador.Pontuacao;
        }
            private void DeterminarVencedor() { 
            if(Maquina.Escolha == Jogador.Escolha)
            {
                //1 ponto pra cada
                Jogador.Pontuacao++;
                Maquina.Pontuacao++;
                Resultado = "Empate!";
            }
            else if ((Jogador.Escolha == EscolhaEnum.PEDRA && Maquina.Escolha == EscolhaEnum.TESOURA) ||
                     (Jogador.Escolha == EscolhaEnum.PAPEL && Maquina.Escolha == EscolhaEnum.PEDRA) ||
                     (Jogador.Escolha == EscolhaEnum.TESOURA && Maquina.Escolha == EscolhaEnum.PAPEL))
            {
                Jogador.Pontuacao += 3;
                Resultado = $"{Jogador.Nome} Venceu!";
            }
            else
            {
                Maquina.Pontuacao += 3;
                Resultado = $"{Maquina.Nome} Venceu!";
            }


        }
    }
}
