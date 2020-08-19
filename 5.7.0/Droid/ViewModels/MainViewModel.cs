using MvvmCross.Core.ViewModels;

namespace Droid.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _hello = "Hello world";
        public string Hello
        {
            get => _hello;
            set
            {
                _hello = value;
                RaisePropertyChanged(() => Hello);
            }
        }
    }
}