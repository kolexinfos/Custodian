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
    
    public partial class DNN_ScheduleHistory
    {
        public int ScheduleHistoryID { get; set; }
        public int ScheduleID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> Succeeded { get; set; }
        public string LogNotes { get; set; }
        public Nullable<System.DateTime> NextStart { get; set; }
        public string Server { get; set; }
    
        public virtual DNN_Schedule DNN_Schedule { get; set; }
    }
}
