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
    
    public partial class DNN_EventLogTypes
    {
        public DNN_EventLogTypes()
        {
            this.DNN_EventLog = new HashSet<DNN_EventLog>();
            this.DNN_EventLogConfig = new HashSet<DNN_EventLogConfig>();
        }
    
        public string LogTypeKey { get; set; }
        public string LogTypeFriendlyName { get; set; }
        public string LogTypeDescription { get; set; }
        public string LogTypeOwner { get; set; }
        public string LogTypeCSSClass { get; set; }
    
        public virtual ICollection<DNN_EventLog> DNN_EventLog { get; set; }
        public virtual ICollection<DNN_EventLogConfig> DNN_EventLogConfig { get; set; }
    }
}
