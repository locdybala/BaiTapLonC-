//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCHBS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_tacgia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_tacgia()
        {
            this.tb_sach = new HashSet<tb_sach>();
        }
    
        public int maTacGia { get; set; }
        public string tenTacGia { get; set; }
        public string gioiTinh { get; set; }
        public Nullable<System.DateTime> ngaySinh { get; set; }
        public string trinhdo { get; set; }
        public string coquan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_sach> tb_sach { get; set; }
    }
}
