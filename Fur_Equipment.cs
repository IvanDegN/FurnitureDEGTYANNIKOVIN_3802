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
    
    public partial class Fur_Equipment
    {
        public int Id_Fur_Equipment { get; set; }
        public string Labelling { get; set; }
        public int Id_Type_Equipment { get; set; }
        public string specifications { get; set; }
    
        public virtual Fur_Type_Equipment Fur_Type_Equipment { get; set; }
    }
}
