//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Imeshma.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public long ID { get; set; }
        public Nullable<long> ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string OldPrice { get; set; }
        public string OfferBadge { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductUrl { get; set; }
    }
}