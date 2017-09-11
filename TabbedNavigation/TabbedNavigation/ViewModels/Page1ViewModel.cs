using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamvvm;

namespace TabbedNavigation.ViewModels
{
    public class Page1ViewModel : BasePageModel
    {
        public string Title { get => GetField<string>(); set => SetField(value); }
        public ICommand NavigateCommand => new Command(async () => await this.PushPageFromCacheAsync<Page3ViewModel>());

        public Page1ViewModel()
        {
            Title = "Page 1";
        }
    }
}
