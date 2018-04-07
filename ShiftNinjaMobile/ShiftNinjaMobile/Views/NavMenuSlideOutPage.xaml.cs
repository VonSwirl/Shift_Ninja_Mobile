using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShiftNinjaMobile.Views
{
    public partial class NavMenuSlideOutPage : ContentPage
    {
        RootPage root;
        List<NavMenuItems> menuItems;

        public NavMenuSlideOutPage(RootPage root)
        {
            this.root = root;
            InitializeComponent();

            if (!App.IsWindows10)
            {
                BackgroundColor = Color.FromHex("#03A9F4");
                ListViewMenu.BackgroundColor = Color.FromHex("#F5F5F5");

            }
   
            BindingContext = new DefaultViewModel
            {
                Title = "Shift Ninja",
                Subtitle = "Shift Ninja",
                Icon = "slideout.png"
            };

            ListViewMenu.ItemsSource = menuItems = new List<NavMenuItems>
                {
                    new NavMenuItems { Title = "Shift Ninja", SelectMenuItem = MenuItem.AboutShiftNinja, Icon ="shiftNinjaIconSmall.png" },
                    new NavMenuItems { Title = "About Developer", SelectMenuItem = MenuItem.AboutDeveloper, Icon = "jeromeProfileSmall.png" },
                    new NavMenuItems{ Title = "View Shift History", SelectMenuItem = MenuItem.ShiftHistory, Icon = "twitternav.png" },
                    new NavMenuItems { Title = "View Profile", SelectMenuItem = MenuItem.UserProfile, Icon = "hm.png" },
                    new NavMenuItems { Title = "View Calender", SelectMenuItem = MenuItem.WorkCalender, Icon = "ratchet.png" }

                };

            ListViewMenu.SelectedItem = menuItems[0];

            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (ListViewMenu.SelectedItem == null)
                    return;

                await this.root.NavigateAsync((int)((NavMenuItems)e.SelectedItem).SelectMenuItem);
            };
        }
    }
}

