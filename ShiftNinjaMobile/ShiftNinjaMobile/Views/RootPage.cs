using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.Generic;
using ShiftNinjaMobile.StandAloneControllers;

namespace ShiftNinjaMobile.Views
{
    public class RootPage : MasterDetailPage
    {
        public static bool IsUWPDesktop { get; set; }
        Dictionary<int, NavigationPage> Pages { get; set; }
        public RootPage()
        {
            if (IsUWPDesktop)
                this.MasterBehavior = MasterBehavior.Popover;

            Pages = new Dictionary<int, NavigationPage>();
            Master = new NavMenuSlideOutPage(this);
            BindingContext = new DefaultViewModel
            {
                Title = "Shift Ninja",
                Icon = "slideout.png"
            };
            //setup home page
            Pages.Add((int)MenuItem.AboutShiftNinja, new ShiftNinjaNavigationPane(new AboutShiftNinjaPage()));
            Detail = Pages[(int)MenuItem.AboutShiftNinja];

            InvalidateMeasure();
        }

        public async Task NavigateAsync(int id)
        {

            if (Detail != null)
            {
                if (IsUWPDesktop || Device.Idiom != TargetIdiom.Tablet)
                    IsPresented = false;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(300);
            }

            Page newPage;
            if (!Pages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)
                        MenuItem.AboutShiftNinja:
                        Pages.Add(id, new ShiftNinjaNavigationPane(new AboutShiftNinjaPage()));
                        break;
                    case (int)
                        MenuItem.WorkCalender:
                        Pages.Add(id, new ShiftNinjaNavigationPane(new WorkCalenderPage()));
                        break;
                    case (int)
                        MenuItem.ShiftHistory:
                        Pages.Add(id, new ShiftNinjaNavigationPane(new ShiftHistoryPage()));
                        break;
                    case (int)
                        MenuItem.UserProfile:
                        Pages.Add(id, new ShiftNinjaNavigationPane(new UserProfilePage()));
                        break;
                    
                    case (int)
                        MenuItem.AboutDeveloper:
                        Pages.Add(id, new ShiftNinjaNavigationPane(new AboutDeveloperPage()));
                        break;
                }
            }

            newPage = Pages[id];
            if (newPage == null)
                return;

            //pop to root for Windows Phone
            if (Detail != null && Device.RuntimePlatform == Device.UWP)
            {
                await Detail.Navigation.PopToRootAsync();
            }

            Detail = newPage;
        }
    }
}

