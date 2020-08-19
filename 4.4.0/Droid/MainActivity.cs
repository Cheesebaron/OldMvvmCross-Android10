using Android.App;
using Android.OS;
using Droid.ViewModels;
using MvvmCross.Droid.Views;

namespace Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    // using MvxActivity crashes :(
    // public class MainActivity : MvxActivity<MainViewModel> 
    public class MainActivity : FixedActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}