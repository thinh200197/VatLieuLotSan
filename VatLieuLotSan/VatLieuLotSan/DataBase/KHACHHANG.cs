namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(10)]
        public string MAKHACHHANG { get; set; }

        [StringLength(50)]
        public string TENKHACHHANG { get; set; }

        public string NHAN { get; set; }

        [StringLength(10)]
        public string LOAIKHACH { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(10)]
        public string SODIENTHOAI { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        public int? DIEMTICHLUY { get; set; }

        public DateTime? NGAYTAO { get; set; }

        [StringLength(50)]
        public string TAOBOI { get; set; }

        public DateTime? NGAYSUA { get; set; }

        [StringLength(50)]
        public string SUABOI { get; set; }

        [StringLength(10)]
        public string GIOHANG { get; set; }

        [StringLength(30)]
        public string TENDANGNHAP { get; set; }

        [StringLength(30)]
        public string MATKHAU { get; set; }

        public virtual GIOHANG GIOHANG1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        public virtual LOAIKHACHHANG LOAIKHACHHANG { get; set; }
    }
}