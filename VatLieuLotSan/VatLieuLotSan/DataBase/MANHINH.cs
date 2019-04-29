namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MANHINH")]
    public partial class MANHINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MANHINH()
        {
            NHOMQUYENs = new HashSet<NHOMQUYEN>();
        }

        [Key]
        [StringLength(10)]
        public string MAMH { get; set; }

        [StringLength(50)]
        public string TENMH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHOMQUYEN> NHOMQUYENs { get; set; }
    }
}
