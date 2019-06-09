namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDAT")]
    public partial class PHIEUDAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDAT()
        {
            CT_PHIEUDAT = new HashSet<CT_PHIEUDAT>();
        }

        [Key]
        [StringLength(100)]
        public string MAPHIEUDAT { get; set; }

        [StringLength(100)]
        public string MANCC { get; set; }

        [StringLength(100)]
        public string MANV { get; set; }

        public DateTime? NGAYDAT { get; set; }

        public double? TONGTIEN { get; set; }

        [StringLength(10)]
        public string TINHTRANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUDAT> CT_PHIEUDAT { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
