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
    
    public partial class DNN_SearchItemWord
    {
        public DNN_SearchItemWord()
        {
            this.DNN_SearchItemWordPosition = new HashSet<DNN_SearchItemWordPosition>();
        }
    
        public int SearchItemWordID { get; set; }
        public int SearchItemID { get; set; }
        public int SearchWordsID { get; set; }
        public int Occurrences { get; set; }
    
        public virtual DNN_SearchItem DNN_SearchItem { get; set; }
        public virtual DNN_SearchWord DNN_SearchWord { get; set; }
        public virtual ICollection<DNN_SearchItemWordPosition> DNN_SearchItemWordPosition { get; set; }
    }
}
