//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class doktor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doktor()
        {
            this.randevu = new HashSet<randevu>();
        }
    
        public int doktorNo { get; set; }
        public string doktorAd { get; set; }
        public string doktorSoyAd { get; set; }
        public string doktorTcNO { get; set; }
        public string doktorTel { get; set; }
        public Nullable<System.DateTime> doktorDtarihi { get; set; }
        public string doktorDyeri { get; set; }
        public string doktorEmail { get; set; }
        public string doktorCinsiyet { get; set; }
        public Nullable<int> klinikNo { get; set; }
        public string klinikAd { get; set; }
    
        public virtual klinik klinik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<randevu> randevu { get; set; }
    }
}