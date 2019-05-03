using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VatLieuLotSan.Areas.Admin.Models
{
    public class DangNhapQuanTriModel
    {
        [Required(ErrorMessage = "Mời nhập tên tài khoản")]
        public string TaiKhoan { get; set; }
        [Required(ErrorMessage = "Mời nhập mật khẩu")]
        public string MatKhau { get; set; }
        public bool MaNV { get; set; }
        public bool GhiNhoToi { get; set; }
    }
}