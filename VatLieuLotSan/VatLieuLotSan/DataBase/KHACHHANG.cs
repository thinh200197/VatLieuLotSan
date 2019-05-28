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
        [StringLength(100)]
        public string MAKHACHHANG { get; set; }

        [StringLength(100)]
        [Display(Name = "Tên Khách Hàng")]
        public string TENKHACHHANG { get; set; }

        [StringLength(100)]
        public string LOAIKHACH { get; set; }

        [StringLength(250)]
        [Display(Name = "Địa chỉ")]
        public string DIACHI { get; set; }

        [StringLength(250)]
        public string Hinh { get; set; }

        [StringLength(10)]
        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]

        public string SODIENTHOAI { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string GIOHANG { get; set; }

        [StringLength(50)]
        [Display(Name = "Tài khoản")]
        public string TENDANGNHAP { get; set; }

        [StringLength(50)]
        [Display(Name = "Mật khẩu")]
        public string MATKHAU { get; set; }

        public virtual GIOHANG GIOHANG1 { get; set; }

        public virtual LOAIKHACHHANG LOAIKHACHHANG { get; set; }
    }
}
