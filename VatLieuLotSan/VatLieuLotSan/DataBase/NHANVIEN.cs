namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            NGUOIDUNGs = new HashSet<NGUOIDUNG>();
            PHIEUGIAOs = new HashSet<PHIEUGIAO>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(50)]
        public string TENNV { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(3)]
        public string GIOITINH { get; set; }

        [StringLength(250)]
        public string DIACHI { get; set; }

        [StringLength(250)]
        public string Hinh { get; set; }

        [StringLength(10)]
        public string CMND { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public DateTime? NGAYTAO { get; set; }

        [StringLength(50)]
        public string TAOBOI { get; set; }

        public DateTime? NGAYSUA { get; set; }

        [StringLength(50)]
        public string SUABOI { get; set; }

        [StringLength(10)]
        public string SODIENTHOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOIDUNG> NGUOIDUNGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUGIAO> PHIEUGIAOs { get; set; }
    }
}
