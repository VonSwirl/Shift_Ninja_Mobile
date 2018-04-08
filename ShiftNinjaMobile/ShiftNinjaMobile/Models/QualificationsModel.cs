using System;
using System.Reflection.Metadata;

namespace ShiftNinjaMobile.Models
{
    public class QualificationsModel
    {


        public QualificationsModel() { }

        public int QualID { get; set; }

        public int RecID { get; set; }

        public string QualTitle { get; set; }

        public Byte QualObject { get; set; }

        public DateTime QualDateAdded { get; set; }

    }
}