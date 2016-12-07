using Android.App;
using MvvmCross.Droid.Views;


namespace CiclistaConsciente.Core.Droid.Views
{
    [Activity(Label = "Ciclista Consciente", MainLauncher = true)]
    public class InicialView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Inicial_View);
        }
    }
}