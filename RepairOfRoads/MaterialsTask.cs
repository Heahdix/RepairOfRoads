//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepairOfRoads
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaterialsTask
    {
        public int id { get; set; }
        public Nullable<int> idTask { get; set; }
        public Nullable<int> idmaterials { get; set; }
    
        public virtual Materials Materials { get; set; }
        public virtual Task Task { get; set; }
    }
}
