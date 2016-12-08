using Android.App;
using MvvmCross.Droid.Views;

namespace CiclistaConsciente.Core.Droid.Views
{
    [Activity(Label = "Ciclista Consciente")]
    public class QuizView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Quiz_View);
        }
    }
}