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
    
    public partial class DNN_AnonymousUsers
    {
        public string UserID { get; set; }
        public int PortalID { get; set; }
        public int TabID { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime LastActiveDate { get; set; }
    
        public virtual DNN_Portals DNN_Portals { get; set; }
    }
}
