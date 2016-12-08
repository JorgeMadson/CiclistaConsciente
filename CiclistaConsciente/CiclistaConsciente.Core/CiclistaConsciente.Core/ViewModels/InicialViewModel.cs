using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace CiclistaConsciente.Core.ViewModels
{
    public class InicialViewModel : MvxViewModel
    {
        public override void Start()
        {
            base.Start();
        }

        public ICommand LeiBtnClick
        {
            get { return new MvxCommand(() => ShowViewModel<LeiViewModel>()); }
        }

        public ICommand OpcaoBtnClick
        {
            get { return new MvxCommand(() => ShowViewModel<OpcaoViewModel>()); }
        }

        public ICommand PercursoBtnClick
        {
            get { return new MvxCommand(() => ShowViewModel<PercursoViewModel>()); }
        }

        public ICommand QuizBtnClick
        {
            get { return new MvxCommand(() => ShowViewModel<QuizViewModel>()); }
        }
    }
}
