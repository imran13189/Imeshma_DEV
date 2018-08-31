using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imeshma.Entity
{
    public class Product
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string OldPrice { get; set; }
        public string OfferBadge { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
