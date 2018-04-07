using Xamarin.Forms;

namespace ShiftNinjaMobile.Views
{
    public class DefaultView : ContentPage
    {
        public DefaultView()
        {
            SetBinding(Page.TitleProperty, new Binding(ShiftNinjaMobile.DefaultViewModel.TitlePropertyName));
            SetBinding(Page.IconProperty, new Binding(ShiftNinjaMobile.DefaultViewModel.IconPropertyName));
        }
    }
}
