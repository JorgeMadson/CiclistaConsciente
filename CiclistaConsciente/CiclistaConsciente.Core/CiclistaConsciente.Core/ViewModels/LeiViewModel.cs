using MvvmCross.Core.ViewModels;
using System.Collections.Generic;

namespace CiclistaConsciente.Core.ViewModels
{
    public class LeiViewModel : MvxViewModel
    {
        public override void Start()
        {
            _leiAtual = 1;
            base.Start();
        }

        //MOSTRAR A PORRA DA LEI AQUI

        string _dica;

        public string Dica { get { return _dica; } set { _dica = value; _dica = "Antes de virar ou mudar de faixa avise!"; } }

        string _situacaoExemplo;

        public string SituacaoExemplo { get { return _situacaoExemplo; } set { _situacaoExemplo = value; _situacaoExemplo = "Você está na faixa da direita mas quer ir para a esquerda, faça um sinal com o braço."; } }

        string _textoLei;

        public string TextoLei { get { return _textoLei; } set { _textoLei = value; _textoLei = "Antes de entrar à direita ou à esquerda, em outra via ou em lotes lindeiros, o condutor deverá: (...) Parágrafo único. durante a manobra de mudança de direção, o condutor deverá ceder passagem aos pedestres e ciclistas, aos veículos que transitem em sentido contrário pela pista da via da qual vai sair, respeitadas as normas de preferência de passagem. "; } }

        int _leiAtual;

        public int LeiAtual { get { return _leiAtual; } set { _leiAtual = value; } }

        public void mudarLei() { LeiAtual++; }
    }
}
