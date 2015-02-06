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
    
    public partial class GSS_Cheques_ScansWorkflows
    {
        public GSS_Cheques_ScansWorkflows()
        {
            this.GSS_Cheques_RejectReasons = new HashSet<GSS_Cheques_RejectReasons>();
            this.GSS_Cheques_ReturnReasons = new HashSet<GSS_Cheques_ReturnReasons>();
        }
    
        public string WorkflowID { get; set; }
        public string ScanID { get; set; }
        public int SourceQueue { get; set; }
        public int DestinationQueue { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public int CreatingAction { get; set; }
        public Nullable<int> ExpiringAction { get; set; }
        public int WorkflowItemStatus { get; set; }
        public Nullable<int> WorkflowStatus { get; set; }
        public int ScanStatus { get; set; }
        public Nullable<System.DateTime> ExpiredDateTime { get; set; }
    
        public virtual ICollection<GSS_Cheques_RejectReasons> GSS_Cheques_RejectReasons { get; set; }
        public virtual ICollection<GSS_Cheques_ReturnReasons> GSS_Cheques_ReturnReasons { get; set; }
        public virtual GSS_Cheques_Scans GSS_Cheques_Scans { get; set; }
    }
}
