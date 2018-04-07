using ShiftNinjaMobile.Models;

namespace ShiftNinjaMobile
{
    public enum MenuItem
    {
        AboutDeveloper,
        AboutShiftNinja,
        WorkCalender,
        ShiftHistory,
        UserProfile
    }
    public class NavMenuItems: DefaultModel
    {
        public NavMenuItems()
        {
            SelectMenuItem = MenuItem.AboutShiftNinja;
        }
        public string Icon { get; set; }
        public MenuItem SelectMenuItem { get; set; }
    }
}

