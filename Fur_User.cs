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
    
    public partial class Fur_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fur_User()
        {
            this.Fur_Order = new HashSet<Fur_Order>();
        }
    
        public int Id_Fur_User { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Id_Role { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte[] Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fur_Order> Fur_Order { get; set; }
        public virtual Fur_Role Fur_Role { get; set; }
    }
}