using Android.App;
using MvvmCross.Droid.Views;

namespace CiclistaConsciente.Core.Droid.Views
{
    [Activity(Label ="Ciclista Consciente") ]
    public class OpcaoView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Opcao_View);
        }
    }
}