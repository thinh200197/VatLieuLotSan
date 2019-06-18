using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VatLieuLotSan.Areas.Admin.Models;
using VatLieuLotSan.Common;
using VatLieuLotSan.DataBase;
using VatLieuLotSan.Models;

namespace VatLieuLotSan.Areas.Admin.Controllers
{
    public class DangNhapController : Controller
    {
        // GET: Admin/DangNhap
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DangNhap(DangNhapQuanTriModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new TaiKhoanNhanVienModel();
                var result = dao.DangNhap(model.TaiKhoan, model.MatKhau);
                if (result)
                {
                    var user = dao.LayThongTinNguoiDung(model.TaiKhoan);
                    var userSession = new DangNhapCommon();
                    userSession.TenDangNhap = user.TENDANGNHAP.ToString();                   

                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "QuanTri");
                }
                else
                {
                    ModelState.AddModelError("", "đăng nhập không đúng.");
                }
            }
            return View("Index");

        }
    }
}