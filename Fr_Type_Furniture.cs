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
    
    public partial class Fr_Type_Furniture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fr_Type_Furniture()
        {
            this.Fur_Furniture = new HashSet<Fur_Furniture>();
        }
    
        public int Id_Fr_Type_Furniture { get; set; }
        public string Type_Furniture { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fur_Furniture> Fur_Furniture { get; set; }
    }
}
