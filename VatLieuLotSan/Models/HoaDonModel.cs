using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VatLieuLotSan.Models
{
    public class HoaDonModel
    {
        [Display(Name ="Tên khách hàng")]
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string GhiChu { get; set; }
        public string HinhThucThanhToan { get; set; }
        public DateTime NgayLap { get; set; }
        public string TinhTrang { get; set; }
    }
}