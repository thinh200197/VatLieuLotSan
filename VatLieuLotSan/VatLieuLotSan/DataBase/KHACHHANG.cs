﻿namespace VatLieuLotSan.DataBase
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
        public string TENKHACHHANG { get; set; }

        [StringLength(100)]
        public string LOAIKHACH { get; set; }

        [StringLength(250)]
        public string DIACHI { get; set; }

        [StringLength(250)]
        public string Hinh { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Nhập số điện thoại")]
        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Vui lòng nhập 10 số")]
        public string SODIENTHOAI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string GIOHANG { get; set; }

        [StringLength(50)]
        public string TENDANGNHAP { get; set; }

        [StringLength(50)]
        public string MATKHAU { get; set; }

        public virtual LOAIKHACHHANG LOAIKHACHHANG { get; set; }
    }
}
