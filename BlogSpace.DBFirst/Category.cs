//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogSpace.DBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.BlogCategories = new HashSet<BlogCategory>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreateBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    
        public virtual ICollection<BlogCategory> BlogCategories { get; set; }
    }
}
