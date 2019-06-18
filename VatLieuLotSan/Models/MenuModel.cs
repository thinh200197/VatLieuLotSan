using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VatLieuLotSan.DataBase;

namespace VatLieuLotSan.Models
{
    public class MenuModel
    {
        DBVatLieuLotSanContext db = null;
        public MenuModel()
        {
            db = new DBVatLieuLotSanContext();
        }
        public List<Menu> DanhMuc(int LoaiMenu)
        {
            return db.Menus.Where(x => x.LoaiMenu == LoaiMenu).ToList();
        }
    }
}