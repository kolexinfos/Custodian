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
    
    public partial class GSS_Cheques_Logs
    {
        public string LogID { get; set; }
        public string ChequeID { get; set; }
        public int Action { get; set; }
        public System.DateTime LogDateTime { get; set; }
        public int UserID { get; set; }
    
        public virtual GSS_Cheques GSS_Cheques { get; set; }
    }
}
