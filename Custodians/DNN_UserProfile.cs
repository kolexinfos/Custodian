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
    
    public partial class DNN_UserProfile
    {
        public int ProfileID { get; set; }
        public int UserID { get; set; }
        public int PropertyDefinitionID { get; set; }
        public string PropertyValue { get; set; }
        public string PropertyText { get; set; }
        public int Visibility { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual DNN_ProfilePropertyDefinition DNN_ProfilePropertyDefinition { get; set; }
        public virtual DNN_Users DNN_Users { get; set; }
    }
}
