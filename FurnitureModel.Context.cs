﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FurnitureBD : DbContext
    {
        public FurnitureBD()
            : base("name=FurnitureBD")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fr_Type_Furniture> Fr_Type_Furniture { get; set; }
        public virtual DbSet<Fur_Equipment> Fur_Equipment { get; set; }
        public virtual DbSet<Fur_Furniture> Fur_Furniture { get; set; }
        public virtual DbSet<Fur_Manager> Fur_Manager { get; set; }
        public virtual DbSet<Fur_Material> Fur_Material { get; set; }
        public virtual DbSet<Fur_Material_Unit_Of_Measurement> Fur_Material_Unit_Of_Measurement { get; set; }
        public virtual DbSet<Fur_Operation_Specification> Fur_Operation_Specification { get; set; }
        public virtual DbSet<Fur_Order> Fur_Order { get; set; }
        public virtual DbSet<Fur_Product> Fur_Product { get; set; }
        public virtual DbSet<Fur_Provider> Fur_Provider { get; set; }
        public virtual DbSet<Fur_Role> Fur_Role { get; set; }
        public virtual DbSet<Fur_Specification_Assembly_Unit> Fur_Specification_Assembly_Unit { get; set; }
        public virtual DbSet<Fur_Specification_hardware> Fur_Specification_hardware { get; set; }
        public virtual DbSet<Fur_Specification_Materials> Fur_Specification_Materials { get; set; }
        public virtual DbSet<Fur_Type_Equipment> Fur_Type_Equipment { get; set; }
        public virtual DbSet<Fur_Type_Materal> Fur_Type_Materal { get; set; }
        public virtual DbSet<Fur_Type_Product> Fur_Type_Product { get; set; }
        public virtual DbSet<Fur_User> Fur_User { get; set; }
        public virtual DbSet<Specification> Specification { get; set; }
    }
}
