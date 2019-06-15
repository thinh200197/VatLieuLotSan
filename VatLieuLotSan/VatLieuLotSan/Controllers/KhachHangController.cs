using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using VatLieuLotSan.Common;
using VatLieuLotSan.DataBase;
using VatLieuLotSan.Models;
using System.Net.Mail;
using System.Text;


namespace VatLieuLotSan.Controllers
{
    public class KhachHangController : Controller
    {
        DBVatLieuLotSanContext db = new DBVatLieuLotSanContext();
        // GET: KhachHang
        public ActionResult KhachHang()
        {
            KHACHHANG kh = (KHACHHANG)Session[CommonConstants.KhachHang];
            return View(kh);
        }



        // Đăng nhập .. test

        public ActionResult Login()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Login(DangNhapKHModel model,string duongDan)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            KhachHangModel kt = new KhachHangModel();
            if (kt.KiemTraTaiKhoan(model.TenDangNhap, model.MatKhau))
            {
                Session[CommonConstants.KhachHang] = model;
                GioHangModel gh = (GioHangModel)Session[CommonConstants.GioHangSession];

                //Thêm thông tin giỏ hàng vào giỏ hàng của tài khoản .
                KhachHangModel khmodel = new KhachHangModel();
                //khmodel.CapNhatGioHangKhachHang();

               



                return Redirect(duongDan);
            }

            return View(model);
        }
        public PartialViewResult PartialKhachHang()
        {
            //var kh = (DangNhapKHModel)Session[CommonConstants.KhachHang];
            //ViewBag.TenKH = "";
            //if (kh != null)
            //{
            //    ViewBag.TenKH = kh.TenKH ;
            //}
           
            return PartialView();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string TaiKhoanKH ,string MatKhauKH,string GhiNho,string Link_Web)
        {
            KhachHangModel model = new KhachHangModel();
            if (model.KiemTraTaiKhoan(TaiKhoanKH,MatKhauKH))
            {
                KHACHHANG kh = new KHACHHANG();
                kh = model.TT_TaiKhoan_KH(TaiKhoanKH);
                Session[CommonConstants.KhachHang] = kh;
                return Redirect(Link_Web);
            }
            return View();
        }
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy([Bind(Include = "TENKHACHHANG,TENDANGNHAP,MATKHAU,SODIENTHOAI,DIACHI,EMAIL")] KHACHHANG kHACHHANG)
        {
            // họp lệ
            if (ModelState.IsValid)
            {
                KhachHangModel kh = new KhachHangModel();

                if (kh.KT_TonTai(kHACHHANG.TENDANGNHAP))
                {
                    ViewBag.ThongBao = "Tên tài khoản đã tồn tại";
                    return View(kHACHHANG);
                }
                try
                {
                    kHACHHANG.MAKHACHHANG = kHACHHANG.TENDANGNHAP;
                    kHACHHANG.Hinh = null;
                    kHACHHANG.LOAIKHACH = "LOAI2";
                    db.SaveChanges();
                    
                    // lưu khách hàng vào database
                    db.KHACHHANGs.Add(kHACHHANG);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
                // các thuộc tính còn thiếu
               

               
                
                Session[CommonConstants.KhachHang] = kHACHHANG;

                return RedirectToAction("Index","Home");
            }
            // không hợp lê
            return View(kHACHHANG);
        }


        ///=============================================================>

        public JsonResult SaveData(KHACHHANG model)
        {
                model.LOAIKHACH = "LOAI1";
                model.Hinh = "";
                model.DIACHI = "";
                model.MAKHACHHANG = "KH"+model.TENDANGNHAP;
                db.KHACHHANGs.Add(model);
                db.SaveChanges();
            BuildEmailTemplate(model.TENDANGNHAP);
            return Json("Registration Successfull", JsonRequestBehavior.AllowGet);
        }
        public ActionResult Confirm(string regId)
        {
            ViewBag.regID = regId;
            return View();
        }
        public JsonResult RegisterConfirm(string regId)
        {
            KHACHHANG Data = db.KHACHHANGs.Where(x => x.TENDANGNHAP == regId).FirstOrDefault();
            //Data.IsValid = true;
            db.SaveChanges();
            var msg = "Kích hoạt thành công !";
            return Json(msg, JsonRequestBehavior.AllowGet);
        }
        public void BuildEmailTemplate(string regID)
        {
            try
            {
                string body = System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/EmailTemplate/") + "Text" + ".cshtml");
                var regInfo = db.KHACHHANGs.Where(x => x.TENDANGNHAP == regID).FirstOrDefault();
                var url = "http://localhost:53109/" + "KhachHang/Confirm?regId=" + regID;
                body = body.Replace("@ViewBag.ConfirmationLink", url);
                body = body.ToString();
                BuildEmailTemplate("Tài khoản của bạn đã được tạo thành công !", body, regInfo.EMAIL);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public static void BuildEmailTemplate(string subjectText, string bodyText, string sendTo)
        {
            string from, to, bcc, cc, subject, body;
            from = "cogantungchut@gmail.com";
            to = sendTo.Trim();
            bcc = "";
            cc = "";
            subject = subjectText;
            StringBuilder sb = new StringBuilder();
            sb.Append(bodyText);
            body = sb.ToString();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(to));
            if (!string.IsNullOrEmpty(bcc))
            {
                mail.Bcc.Add(new MailAddress(bcc));
            }
            if (!string.IsNullOrEmpty(cc))
            {
                mail.CC.Add(new MailAddress(cc));
            }
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            SendEmail(mail);
        }

        public static void SendEmail(MailMessage mail)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential("cogantungchut@gmail.com", "coganchienthang1997");
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult CheckValidUser(KHACHHANG model)
        {
            string result = "Fail";
                var DataItem = db.KHACHHANGs.Where(x => x.TENDANGNHAP == model.TENDANGNHAP && x.MATKHAU == model.MATKHAU).SingleOrDefault();
                if (DataItem != null)
                {
                    Session[CommonConstants.KhachHang] = DataItem;
                    Session["UserID"] = DataItem.TENDANGNHAP.ToString();
                    Session["UserName"] = DataItem.TENKHACHHANG.ToString();
                    result = "Success";
                }
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public ActionResult AfterLogin(string urlLink)
        {
            if (Session["UserID"] != null)
            {

                return Redirect(urlLink);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout(string urlLink)
        {
            Session.Clear();
            Session.Abandon();
            return Redirect(urlLink);
        }

        public ActionResult Text()
        {
            return View();
        }
    }
}