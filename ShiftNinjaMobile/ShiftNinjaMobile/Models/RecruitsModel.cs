using System.Reflection.Metadata;

namespace ShiftNinjaMobile.Models
{
    public class RecruitsModel
    {
        public RecruitsModel() { }

        public int RecID { get; set; }
        public string RecRecruitRef { get; set; }
        public string RecFirstN { get; set; }
        public string RecSurN { get; set; }
        public string RecForeN { get; set; }
        public string RecTitle { get; set; }
        public string RecAddress { get; set; }
        public string RecContactHome { get; set; }
        public string RecContactMob { get; set; }
        public string RecEmail { get; set; }
        public bool RecActive { get; set; }
        public string RecExperience { get; set; }
        public byte RecProfilePic { get; set; }
    }
}