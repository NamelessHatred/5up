//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp5
{
    using System;
    using System.Collections.Generic;
    
    public partial class CATS
    {
        public int ID_Cats { get; set; }
        public string CatName { get; set; }
        public Nullable<int> CatAge { get; set; }
        public string CatColor { get; set; }
        public string CatType { get; set; }
        public int Typey_ID { get; set; }
    
        public virtual Animals Animals { get; set; }
    }
}