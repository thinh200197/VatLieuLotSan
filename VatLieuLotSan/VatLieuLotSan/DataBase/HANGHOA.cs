namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGHOA")]
    public partial class HANGHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGHOA()
        {
            CT_HOADON = new HashSet<CT_HOADON>();
            CT_PHIEUDAT = new HashSet<CT_PHIEUDAT>();
            CT_PHIEUNHAP = new HashSet<CT_PHIEUNHAP>();
            CTKHUYENMAIs = new HashSet<CTKHUYENMAI>();
            CTPHIEUGIAOs = new HashSet<CTPHIEUGIAO>();
        }

        [Key]
        [StringLength(100)]
        public string MAHANG { get; set; }

        [StringLength(100)]
        public string TENHANG { get; set; }

        [StringLength(100)]
        public string MALOAI { get; set; }

        [StringLength(30)]
        public string DONVITINH { get; set; }

        public string MOTA { get; set; }

        public string HINH { get; set; }

        [StringLength(100)]
        public string MAU { get; set; }

        public double? GIANHAP { get; set; }

        public double? GIABAN { get; set; }

        public DateTime? NGAYTAO { get; set; }

        public int? SOLUONG { get; set; }

        public DateTime? NOIBAT { get; set; }

        public int? LUOTXEM { get; set; }

        [StringLength(10)]
        public string TINHTRANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUDAT> CT_PHIEUDAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUNHAP> CT_PHIEUNHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTKHUYENMAI> CTKHUYENMAIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUGIAO> CTPHIEUGIAOs { get; set; }

        public virtual LOAIHANG LOAIHANG { get; set; }

        public virtual MAUSAC MAUSAC { get; set; }

        public virtual QUYCACH QUYCACH { get; set; }
    }
}
