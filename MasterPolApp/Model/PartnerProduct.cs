//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPolApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartnerProduct
    {
        public int PartnerProductsID { get; set; }
        public int ProductsID { get; set; }
        public int PartnerID { get; set; }
        public string ProductsCount { get; set; }
        public string DateSale { get; set; }
    
        public virtual Partner Partner { get; set; }
        public virtual Product Product { get; set; }
    }
}
