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
    public class NGUOIDUNGsController : Controller
    {
        private DBVatLieuLotSanContext db = new DBVatLieuLotSanContext();

        // GET: Admin/NGUOIDUNGs
        public ActionResult Index()
        {
            var nGUOIDUNGs = db.NGUOIDUNGs.Include(n => n.CHITIETNHOMQUYEN).Include(n => n.NHANVIEN);
            return View(nGUOIDUNGs.ToList());
        }

        // GET: Admin/NGUOIDUNGs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NGUOIDUNG nGUOIDUNG = db.NGUOIDUNGs.Find(id);
            if (nGUOIDUNG == null)
            {
                return HttpNotFound();
            }
            return View(nGUOIDUNG);
        }

        // GET: Admin/NGUOIDUNGs/Create
        public ActionResult Create()
        {
            ViewBag.TENDANGNHAP = new SelectList(db.CHITIETNHOMQUYENs, "TENDANGNHAP", "MANHOM");
            ViewBag.MANV = new SelectList(db.NHANVIENs, "MANV", "TENNV");
            return View();
        }

        // POST: Admin/NGUOIDUNGs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TENDANGNHAP,MANV,MATKHAU,NGAYTAO,TAOBOI,NGAYSUA,SUABOI,HOATDONG")] NGUOIDUNG nGUOIDUNG)
        {
            if (ModelState.IsValid)
            {
                db.NGUOIDUNGs.Add(nGUOIDUNG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TENDANGNHAP = new SelectList(db.CHITIETNHOMQUYENs, "TENDANGNHAP", "MANHOM", nGUOIDUNG.TENDANGNHAP);
            ViewBag.MANV = new SelectList(db.NHANVIENs, "MANV", "TENNV", nGUOIDUNG.MANV);
            return View(nGUOIDUNG);
        }

        // GET: Admin/NGUOIDUNGs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NGUOIDUNG nGUOIDUNG = db.NGUOIDUNGs.Find(id);
            if (nGUOIDUNG == null)
            {
                return HttpNotFound();
            }
            ViewBag.TENDANGNHAP = new SelectList(db.CHITIETNHOMQUYENs, "TENDANGNHAP", "MANHOM", nGUOIDUNG.TENDANGNHAP);
            ViewBag.MANV = new SelectList(db.NHANVIENs, "MANV", "TENNV", nGUOIDUNG.MANV);
            return View(nGUOIDUNG);
        }

        // POST: Admin/NGUOIDUNGs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TENDANGNHAP,MANV,MATKHAU,NGAYTAO,TAOBOI,NGAYSUA,SUABOI,HOATDONG")] NGUOIDUNG nGUOIDUNG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nGUOIDUNG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TENDANGNHAP = new SelectList(db.CHITIETNHOMQUYENs, "TENDANGNHAP", "MANHOM", nGUOIDUNG.TENDANGNHAP);
            ViewBag.MANV = new SelectList(db.NHANVIENs, "MANV", "TENNV", nGUOIDUNG.MANV);
            return View(nGUOIDUNG);
        }

        // GET: Admin/NGUOIDUNGs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NGUOIDUNG nGUOIDUNG = db.NGUOIDUNGs.Find(id);
            if (nGUOIDUNG == null)
            {
                return HttpNotFound();
            }
            return View(nGUOIDUNG);
        }

        // POST: Admin/NGUOIDUNGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NGUOIDUNG nGUOIDUNG = db.NGUOIDUNGs.Find(id);
            db.NGUOIDUNGs.Remove(nGUOIDUNG);
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
