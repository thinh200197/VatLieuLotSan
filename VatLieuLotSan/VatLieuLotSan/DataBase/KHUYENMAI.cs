namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUYENMAI")]
    public partial class KHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUYENMAI()
        {
            CTKHUYENMAIs = new HashSet<CTKHUYENMAI>();
        }

        [Key]
        [StringLength(100)]
        public string MAKM { get; set; }

        [StringLength(100)]
        public string TENKM { get; set; }

        public DateTime? NGAYBATDAU { get; set; }

        public DateTime? NGAYKETTHUC { get; set; }

        [StringLength(100)]
        public string HINHTHUCKM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTKHUYENMAI> CTKHUYENMAIs { get; set; }
    }
}
