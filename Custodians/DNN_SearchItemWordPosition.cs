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
    
    public partial class DNN_SearchItemWordPosition
    {
        public int SearchItemWordPositionID { get; set; }
        public int SearchItemWordID { get; set; }
        public int ContentPosition { get; set; }
    
        public virtual DNN_SearchItemWord DNN_SearchItemWord { get; set; }
    }
}
