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
    
    public partial class DNN_ModulePermission
    {
        public int ModulePermissionID { get; set; }
        public int ModuleID { get; set; }
        public int PermissionID { get; set; }
        public bool AllowAccess { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual DNN_Modules DNN_Modules { get; set; }
        public virtual DNN_Permission DNN_Permission { get; set; }
        public virtual DNN_Users DNN_Users { get; set; }
    }
}
