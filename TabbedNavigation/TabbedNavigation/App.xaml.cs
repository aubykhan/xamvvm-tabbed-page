using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TabbedNavigation.ViewModels;
using Xamarin.Forms;
using Xamvvm;

namespace TabbedNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var factory = new XamvvmFormsFactory(this);
            XamvvmCore.SetCurrentFactory(factory);

            factory.RegisterTabbedPage<MainPageViewModel>(() =>
            {
                return new List<IBasePage<IBasePageModel>> {
                    new XamvvmNavigationPage(factory.GetPageFromCache<Page1ViewModel>() as Page) { Title = "Page1" },
                    new XamvvmNavigationPage(factory.GetPageFromCache<Page2ViewModel>() as Page) { Title = "Page2" },
                };
            });

            MainPage = this.GetPageFromCache<MainPageViewModel>() as Page;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
