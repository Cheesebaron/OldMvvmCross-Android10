using System.Collections.Generic;
using System.Reflection;
using Android.Content;
using Droid.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;

namespace Droid
{
    public class App : MvxApplication
    {
        public App()
        {
            RegisterAppStart<MainViewModel>();
        }
    }

    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IEnumerable<Assembly> GetViewModelAssemblies()
        {
            var assemblies = new List<Assembly>(base.GetViewModelAssemblies());
            assemblies.Add(this.GetType().Assembly);
            return assemblies;
        }
    }
}