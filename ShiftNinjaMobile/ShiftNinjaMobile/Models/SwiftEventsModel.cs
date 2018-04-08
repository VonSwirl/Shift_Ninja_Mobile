using System;

namespace ShiftNinjaMobile.Models
{
    public class SwiftEventsModel
    {
        public SwiftEventsModel() { }

        public int ShiftID { get; set; }
        public int RecID { get; set; }
        public string ShiftCompanyName { get; set; }
        public string ShiftAddress { get; set; }
        public string ShiftRole { get; set; }
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }
        public int ShiftRateCode { get; set; }
        public float ShiftPay { get; set; }
    }
}