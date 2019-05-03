using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VatLieuLotSan.DataBase;

namespace VatLieuLotSan.Areas.Admin.Controllers
{
    public class KHACHHANGsController : Controller
    {
        private DBVatLieuLotSanContext db = new DBVatLieuLotSanContext();

        // GET: Admin/KHACHHANGs
        public ActionResult Index()
        {
            var kHACHHANGs = db.KHACHHANGs.Include(k => k.GIOHANG1).Include(k => k.LOAIKHACHHANG);
            return View(kHACHHANGs.ToList());
        }

        // GET: Admin/KHACHHANGs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHACHHANG kHACHHANG = db.KHACHHANGs.Find(id);
            if (kHACHHANG == null)
            {
                return HttpNotFound();
            }
            return View(kHACHHANG);
        }

        // GET: Admin/KHACHHANGs/Create
        public ActionResult Create()
        {
            ViewBag.GIOHANG = new SelectList(db.GIOHANGs, "MAGIOHANG", "MAGIOHANG");
            ViewBag.LOAIKHACH = new SelectList(db.LOAIKHACHHANGs, "MALOAI", "TENLOAN");
            return View();
        }

        // POST: Admin/KHACHHANGs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MAKHACHHANG,TENKHACHHANG,NHAN,LOAIKHACH,DIACHI,SODIENTHOAI,EMAIL,NGAYTAO,TAOBOI,NGAYSUA,SUABOI,GIOHANG,TENDANGNHAP,MATKHAU")] KHACHHANG kHACHHANG)
        {
            if (ModelState.IsValid)
            {
                db.KHACHHANGs.Add(kHACHHANG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GIOHANG = new SelectList(db.GIOHANGs, "MAGIOHANG", "MAGIOHANG", kHACHHANG.GIOHANG);
            ViewBag.LOAIKHACH = new SelectList(db.LOAIKHACHHANGs, "MALOAI", "TENLOAN", kHACHHANG.LOAIKHACH);
            return View(kHACHHANG);
        }

        // GET: Admin/KHACHHANGs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHACHHANG kHACHHANG = db.KHACHHANGs.Find(id);
            if (kHACHHANG == null)
            {
                return HttpNotFound();
            }
            ViewBag.GIOHANG = new SelectList(db.GIOHANGs, "MAGIOHANG", "MAGIOHANG", kHACHHANG.GIOHANG);
            ViewBag.LOAIKHACH = new SelectList(db.LOAIKHACHHANGs, "MALOAI", "TENLOAN", kHACHHANG.LOAIKHACH);
            return View(kHACHHANG);
        }

        // POST: Admin/KHACHHANGs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MAKHACHHANG,TENKHACHHANG,NHAN,LOAIKHACH,DIACHI,SODIENTHOAI,EMAIL,NGAYTAO,TAOBOI,NGAYSUA,SUABOI,GIOHANG,TENDANGNHAP,MATKHAU")] KHACHHANG kHACHHANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kHACHHANG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GIOHANG = new SelectList(db.GIOHANGs, "MAGIOHANG", "MAGIOHANG", kHACHHANG.GIOHANG);
            ViewBag.LOAIKHACH = new SelectList(db.LOAIKHACHHANGs, "MALOAI", "TENLOAN", kHACHHANG.LOAIKHACH);
            return View(kHACHHANG);
        }

        // GET: Admin/KHACHHANGs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHACHHANG kHACHHANG = db.KHACHHANGs.Find(id);
            if (kHACHHANG == null)
            {
                return HttpNotFound();
            }
            return View(kHACHHANG);
        }

        // POST: Admin/KHACHHANGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KHACHHANG kHACHHANG = db.KHACHHANGs.Find(id);
            db.KHACHHANGs.Remove(kHACHHANG);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
