using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VatLieuLotSan.Models
{
    public class HoaDonModel
    {
        public string TenKH { get; set; }
        public string SĐT { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public string HinhThucThanhToan { get; set; }
        public DateTime NgayLap { get; set; }
        public string TinhTrang { get; set; }
    }
}