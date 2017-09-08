using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedNavigation.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamvvm;

namespace TabbedNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage, IBasePage<MainPageViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}