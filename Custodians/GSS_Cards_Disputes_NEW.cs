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
    
    public partial class GSS_Cards_Disputes_NEW
    {
        public GSS_Cards_Disputes_NEW()
        {
            this.GSS_Cards_Disputes_Logs = new HashSet<GSS_Cards_Disputes_Logs>();
        }
    
        public string DisputeID { get; set; }
        public string LogCode { get; set; }
        public string Stan { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string CardNumber { get; set; }
        public string TerminalID { get; set; }
        public int Status { get; set; }
        public int CreatedByUserID { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public int ClosedByUserID { get; set; }
        public System.DateTime ClosedDateTime { get; set; }
        public string BranchResponseUrl { get; set; }
        public int CardProvider { get; set; }
        public string ResponseMode { get; set; }
        public string ApprovalStatus { get; set; }
        public Nullable<System.Guid> TerminalGUID { get; set; }
        public long ING_ROW_ID { get; set; }
        public byte[] CardNumber_NEW { get; set; }
    
        public virtual ICollection<GSS_Cards_Disputes_Logs> GSS_Cards_Disputes_Logs { get; set; }
    }
}
