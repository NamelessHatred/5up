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
    
    public partial class RATS
    {
        public int ID_Rats { get; set; }
        public string RatName { get; set; }
        public Nullable<int> RatAge { get; set; }
        public string RatColor { get; set; }
        public string RatType { get; set; }
        public int Typey_ID { get; set; }
    
        public virtual Animals Animals { get; set; }
    }
}