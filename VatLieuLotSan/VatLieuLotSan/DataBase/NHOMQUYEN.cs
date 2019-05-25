namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHOMQUYEN")]
    public partial class NHOMQUYEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHOMQUYEN()
        {
            CHITIETNHOMQUYENs = new HashSet<CHITIETNHOMQUYEN>();
            MANHINHs = new HashSet<MANHINH>();
        }

        [Key]
        [StringLength(100)]
        public string MANHOM { get; set; }

        [StringLength(100)]
        public string TENNHOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHOMQUYEN> CHITIETNHOMQUYENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MANHINH> MANHINHs { get; set; }
    }
}
