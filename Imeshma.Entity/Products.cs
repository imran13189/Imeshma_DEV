using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imeshma.Entity
{
    public class Products
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
