using MvvmCross.Core.ViewModels;
using System;

namespace CiclistaConsciente.Core.ViewModels
{
    public class LeiViewModel : MvxViewModel
    {
        public override void Start()
        {
            GerarNovaLei();
            base.Start();
        }

        int _leiGerada;

        public int LeiGerada
        {
            get { return _leiGerada; }
            set { _leiGerada = value; GerarNovaLei(); }
        }

        void GerarNovaLei()
        {
            int qntLeis = new Leis().mostrarLeis().Count;
            Random rand = new Random();
            LeiGerada = rand.Next(qntLeis);
        }
    }
}
