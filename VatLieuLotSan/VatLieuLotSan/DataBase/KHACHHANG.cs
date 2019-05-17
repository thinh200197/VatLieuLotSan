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
        [Key]
        [StringLength(10)]
        public string MAKHACHHANG { get; set; }

        [StringLength(50)]
        [Display(Name ="Tên khách hàng")]
        public string TENKHACHHANG { get; set; }

        public string NHAN { get; set; }

        [StringLength(10)]
        public string LOAIKHACH { get; set; }

        [StringLength(100)]
        [Display(Name ="Địa chỉ")]
        public string DIACHI { get; set; }

        [StringLength(250)]
        [Display(Name = "Hình")]
        public string Hinh { get; set; }

        [StringLength(10)]
        [Display(Name = "Số điện thoại")]
        public string SODIENTHOAI { get; set; }

        [StringLength(30)]
        [Display(Name = "Email")]
        public string EMAIL { get; set; }

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

        public virtual LOAIKHACHHANG LOAIKHACHHANG { get; set; }
    }
}
