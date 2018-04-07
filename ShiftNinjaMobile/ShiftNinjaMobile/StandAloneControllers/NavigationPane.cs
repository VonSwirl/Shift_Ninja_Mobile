using Xamarin.Forms;

namespace ShiftNinjaMobile.StandAloneControllers
{
    public class ShiftNinjaNavigationPane : NavigationPage
    {
        public ShiftNinjaNavigationPane(Page root) : base(root)
        {
            Init();
        }

        public ShiftNinjaNavigationPane()
        {
            Init();
        }

        void Init()
        {

            BarBackgroundColor = Color.FromHex("#E8A668");
            BarTextColor = Color.Black;
        }
    }
}