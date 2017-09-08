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
        public const string Title = "Page 1";
        public ICommand NavigateCommand => new Command(async () => await this.PushPageFromCacheAsync<Page3ViewModel>());
    }
}
