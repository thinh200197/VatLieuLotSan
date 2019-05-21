using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VatLieuLotSan.DataBase;

namespace VatLieuLotSan.Models
{
    public class DangNhapKHModel
    {
        public string TenKH { get; set; }
        [Required]
        [Display(Name = "Tài khoản")]
        public string TenDangNhap { get; set;}
        [Required]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }
        public bool GhiNhoToi { get; set; }

    }
}