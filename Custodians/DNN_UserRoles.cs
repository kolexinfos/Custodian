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
    
    public partial class DNN_UserRoles
    {
        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<bool> IsTrialUsed { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
    
        public virtual DNN_Roles DNN_Roles { get; set; }
        public virtual DNN_Users DNN_Users { get; set; }
    }
}
