using System.Collections.ObjectModel;

namespace ShiftNinjaMobile.ViewModels
{
    class NavMenuViewModel : DefaultViewModel
  
    {
        public ObservableCollection<NavMenuItems> MenuItems { get; set; }

        public NavMenuViewModel() {
            CanLoadMore = true;
            Title = "Shift Ninja";

            MenuItems = new ObservableCollection<NavMenuItems>();

            MenuItems.Add(new NavMenuItems
            {
                Id = 0,
                Title = "About Shift Ninja",
                SelectMenuItem = MenuItem.AboutShiftNinja,
                Icon = "icon.png"
            });

            MenuItems.Add(new NavMenuItems
            {
                Id = 1,
                Title = "Calender",
                SelectMenuItem = MenuItem.WorkCalender,
                Icon = "workCalender.png"
            });

            MenuItems.Add(new NavMenuItems
            {
                Id = 2,
                Title = "Shift History",
                SelectMenuItem = MenuItem.ShiftHistory,
                Icon = "history.png"
            });  

            MenuItems.Add(new NavMenuItems
            {
                Id = 3,
                Title = "My Profile",
                SelectMenuItem = MenuItem.UserProfile,
                Icon = "userProfile.png"
            });

            MenuItems.Add(new NavMenuItems
            {
                Id = 4,
                Title = "About Developer",
                SelectMenuItem = MenuItem.AboutDeveloper,
                Icon = "devProfile.png"
            });
        }
    }
}
