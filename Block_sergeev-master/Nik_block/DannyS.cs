//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tinker_quest
{
    using System;
    using System.Collections.Generic;
    
    public partial class DannyS
    {
        public int IdContract { get; set; }
        public int IdGoods { get; set; }
        public double Price { get; set; }
        public string Count { get; set; }
        public string Status { get; set; }
    
        public virtual DannyDZ DannyDZ { get; set; }
        public virtual IdProdukts IdProdukts { get; set; }
    }
}