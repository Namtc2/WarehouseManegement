//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarehouseManegement.Model
{
    using System;
    using System.Collections.Generic;
    using WarehouseManegement.ViewModel;

    public partial class Unit: BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unit()
        {
            this.Objects = new HashSet<Object>();
        }
    
        public int Id { get; set; }
        public string _DisplayName;
        public string DisplayName { get=>_DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Object> Objects { get; set; }
    }
}
