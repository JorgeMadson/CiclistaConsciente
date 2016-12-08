using Android.App;
using MvvmCross.Droid.Views;

namespace CiclistaConsciente.Core.Droid.Views
{
    [Activity(Label = "Ciclista Consciente")]
    public class PercursoView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Percurso_View);
        }
    }
}