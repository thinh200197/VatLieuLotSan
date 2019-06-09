using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VatLieuLotSan.DataBase;

namespace VatLieuLotSan.Models
{
    [Serializable]
    public class GioHangModel
    {
        public HANGHOA SanPham { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }
        public GioHangModel()
        {
            SanPham = null;
            SoLuong = 0;
            ThanhTien = 0;
        }

    }
    

}