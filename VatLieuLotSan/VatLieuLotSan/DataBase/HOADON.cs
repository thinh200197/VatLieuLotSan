namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            PHIEUGIAOs = new HashSet<PHIEUGIAO>();
        }

        [Key]
        [StringLength(10)]
        public string MAHD { get; set; }

        public DateTime? NGAYLAP { get; set; }

        public double? GIAMGIA { get; set; }

        public double? TONGTIEN { get; set; }

        [StringLength(10)]
        public string MAKHACHHANG { get; set; }

        public DateTime? NGAYTAO { get; set; }

        [StringLength(50)]
        public string TAOBOI { get; set; }

        public DateTime? NGAYSUA { get; set; }

        [StringLength(50)]
        public string SUABOI { get; set; }

        [StringLength(10)]
        public string TINHTRANG { get; set; }

        public virtual CT_HOADON CT_HOADON { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUGIAO> PHIEUGIAOs { get; set; }
    }
}
