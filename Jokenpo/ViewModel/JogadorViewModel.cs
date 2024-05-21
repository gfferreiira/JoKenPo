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

        public JogadorViewModel() 
        { 
                    
        }


        [ObservableProperty]
        private string _nome;

        [ObservableProperty]
        private EscolhaEnum _escolha;

        [ObservableProperty]
        private int _pontuacao;

        private ObservableCollection<int> _escolhaList = new ObservableCollection<int>();
        private ObservableCollection<int> EscolhaLista
        {
            get { return _escolhaList; }
            set { _escolhaList = value; }
        }

        public ICommand PlayCommand { get; }

        public void Play()
        {
            EscolhaEnum escolhaMaquina = (EscolhaEnum)new Random().Next(3);

            Jogador jogador = new Jogador(Nome, Escolha, Pontuacao);

            Jogador maquina = new Jogador("Maquina", escolhaMaquina, Pontuacao);
        
            if(maquina.Escolha == jogador.Escolha)
            {
                //1 ponto pra cada
                jogador.Pontuacao = jogador.Pontuacao + 1;
                maquina.Pontuacao += 1;
            }

            if (jogador.Escolha == EscolhaEnum.PEDRA) 
            { 
                if ()    
            }
        }
    }
}
