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
    
    public partial class TOOLS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOOLS()
        {
            this.BuyMoments = new HashSet<BuyMoments>();
        }
    
        public int ID_TOOL { get; set; }
        public string ToolName { get; set; }
        public string ToolType { get; set; }
        public Nullable<int> HowMuchTool { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyMoments> BuyMoments { get; set; }
    }
}