using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamvvm;

namespace TabbedNavigation.ViewModels
{
    public class Page3ViewModel : BasePageModel
    {
        public string Title { get => GetField<string>(); set => SetField(value); }

        public Page3ViewModel()
        {
            Title = "Page 3";
        }
    }
}
