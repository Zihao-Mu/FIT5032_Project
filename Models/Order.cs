//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FIT5032_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderMenu = new HashSet<OrderMenu>();
        }
    
        public int OrderId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string Category { get; set; }
        public string UserId { get; set; }
        public Nullable<int> TableId { get; set; }
        public int DishId { get; set; }
    
        public virtual DiningTable DiningTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderMenu> OrderMenu { get; set; }
    }
}
