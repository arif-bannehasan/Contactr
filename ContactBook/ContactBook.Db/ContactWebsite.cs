//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactBook.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactWebsite
    {
        public int WebsiteId { get; set; }
        public string Website { get; set; }
        public long BookId { get; set; }
    
        public virtual ContactBook ContactBook { get; set; }
    }
}
