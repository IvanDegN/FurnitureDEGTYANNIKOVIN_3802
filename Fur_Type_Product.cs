//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FurnitureDEGTYANNIKOVIN_3802
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fur_Type_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fur_Type_Product()
        {
            this.Fur_Specification_Assembly_Unit = new HashSet<Fur_Specification_Assembly_Unit>();
        }
    
        public int Id_Fr_Type_Product { get; set; }
        public string Type_Product { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fur_Specification_Assembly_Unit> Fur_Specification_Assembly_Unit { get; set; }
    }
}