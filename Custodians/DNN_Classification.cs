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
    
    public partial class DNN_Classification
    {
        public DNN_Classification()
        {
            this.DNN_Classification1 = new HashSet<DNN_Classification>();
            this.DNN_VendorClassification = new HashSet<DNN_VendorClassification>();
        }
    
        public int ClassificationId { get; set; }
        public string ClassificationName { get; set; }
        public Nullable<int> ParentId { get; set; }
    
        public virtual ICollection<DNN_Classification> DNN_Classification1 { get; set; }
        public virtual DNN_Classification DNN_Classification2 { get; set; }
        public virtual ICollection<DNN_VendorClassification> DNN_VendorClassification { get; set; }
    }
}
