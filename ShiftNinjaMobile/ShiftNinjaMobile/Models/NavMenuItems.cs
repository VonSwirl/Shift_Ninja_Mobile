using ShiftNinjaMobile.Models;

namespace ShiftNinjaMobile
{
    public enum MenuItem
    {
        AboutShiftNinja,
        WorkCalender,
        ShiftHistory,
        UserProfile,
        AboutDeveloper
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

