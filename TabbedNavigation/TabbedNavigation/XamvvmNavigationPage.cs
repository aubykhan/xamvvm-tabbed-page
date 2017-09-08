using Xamarin.Forms;
using Xamvvm;

namespace TabbedNavigation
{
    internal class XamvvmNavigationPage : NavigationPage, IBasePage<IBasePageModel>
    {
        public XamvvmNavigationPage(Page root) : base(root)
        {
        }
    }
}