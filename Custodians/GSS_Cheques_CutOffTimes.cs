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
    
    public partial class GSS_Cheques_CutOffTimes
    {
        public string CutOffTimeID { get; set; }
        public string BusinessOfficeID { get; set; }
        public int SessionID { get; set; }
        public int MinutesBeforeSession { get; set; }
    
        public virtual GSS_BusinessOffices GSS_BusinessOffices { get; set; }
    }
}
