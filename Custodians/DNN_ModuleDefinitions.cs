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
    
    public partial class DNN_ModuleDefinitions
    {
        public DNN_ModuleDefinitions()
        {
            this.DNN_ModuleControls = new HashSet<DNN_ModuleControls>();
            this.DNN_Modules = new HashSet<DNN_Modules>();
        }
    
        public int ModuleDefID { get; set; }
        public string FriendlyName { get; set; }
        public int DesktopModuleID { get; set; }
        public int DefaultCacheTime { get; set; }
    
        public virtual DNN_DesktopModules DNN_DesktopModules { get; set; }
        public virtual ICollection<DNN_ModuleControls> DNN_ModuleControls { get; set; }
        public virtual ICollection<DNN_Modules> DNN_Modules { get; set; }
    }
}