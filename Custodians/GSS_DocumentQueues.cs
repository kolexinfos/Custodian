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
    
    public partial class GSS_DocumentQueues
    {
        public string DocumentQueueID { get; set; }
        public string DocumentID { get; set; }
        public int UserID { get; set; }
    
        public virtual DNN_Users DNN_Users { get; set; }
        public virtual GSS_Documents GSS_Documents { get; set; }
    }
}
