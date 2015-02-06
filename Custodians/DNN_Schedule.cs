//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Custodians
{
    using System;
    using System.Collections.Generic;
    
    public partial class DNN_Schedule
    {
        public DNN_Schedule()
        {
            this.DNN_ScheduleHistory = new HashSet<DNN_ScheduleHistory>();
            this.DNN_ScheduleItemSettings = new HashSet<DNN_ScheduleItemSettings>();
        }
    
        public int ScheduleID { get; set; }
        public string TypeFullName { get; set; }
        public int TimeLapse { get; set; }
        public string TimeLapseMeasurement { get; set; }
        public int RetryTimeLapse { get; set; }
        public string RetryTimeLapseMeasurement { get; set; }
        public int RetainHistoryNum { get; set; }
        public string AttachToEvent { get; set; }
        public bool CatchUpEnabled { get; set; }
        public bool Enabled { get; set; }
        public string ObjectDependencies { get; set; }
        public string Servers { get; set; }
    
        public virtual ICollection<DNN_ScheduleHistory> DNN_ScheduleHistory { get; set; }
        public virtual ICollection<DNN_ScheduleItemSettings> DNN_ScheduleItemSettings { get; set; }
    }
}