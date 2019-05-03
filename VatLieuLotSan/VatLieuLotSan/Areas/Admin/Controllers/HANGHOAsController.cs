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
    public class HANGHOAsController : Controller
    {
        private DBVatLieuLotSanContext db = new DBVatLieuLotSanContext();

        // GET: Admin/HANGHOAs
        public ActionResult Index()
        {
            var hANGHOAs = db.HANGHOAs.Include(h => h.LOAIHANG).Include(h => h.MAUSAC);
            return View(hANGHOAs.ToList());
        }

        // GET: Admin/HANGHOAs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HANGHOA hANGHOA = db.HANGHOAs.Find(id);
            if (hANGHOA == null)
            {
                return HttpNotFound();
            }
            return View(hANGHOA);
        }

        // GET: Admin/HANGHOAs/Create
        public ActionResult Create()
        {
            ViewBag.MALOAI = new SelectList(db.LOAIHANGs, "MALOAI", "TENLOAI");
            ViewBag.MAU = new SelectList(db.MAUSACs, "MAMAU", "NHAN");
            return View();
        }

        // POST: Admin/HANGHOAs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MAHANG,TENHANG,NHAN,MALOAI,DONVITINH,MOTA,NHIEUANH,HINH,MAU,GIANHAP,GIABAN,SOLUONG,NGAYTAO,TAOBOI,NGAYSUA,SUABOI,NOIBAT,LUOTXEM,TINHTRANG")] HANGHOA hANGHOA)
        {
            if (ModelState.IsValid)
            {
                db.HANGHOAs.Add(hANGHOA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MALOAI = new SelectList(db.LOAIHANGs, "MALOAI", "TENLOAI", hANGHOA.MALOAI);
            ViewBag.MAU = new SelectList(db.MAUSACs, "MAMAU", "NHAN", hANGHOA.MAU);
            return View(hANGHOA);
        }

        // GET: Admin/HANGHOAs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HANGHOA hANGHOA = db.HANGHOAs.Find(id);
            if (hANGHOA == null)
            {
                return HttpNotFound();
            }
            ViewBag.MALOAI = new SelectList(db.LOAIHANGs, "MALOAI", "TENLOAI", hANGHOA.MALOAI);
            ViewBag.MAU = new SelectList(db.MAUSACs, "MAMAU", "NHAN", hANGHOA.MAU);
            return View(hANGHOA);
        }

        // POST: Admin/HANGHOAs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MAHANG,TENHANG,NHAN,MALOAI,DONVITINH,MOTA,NHIEUANH,HINH,MAU,GIANHAP,GIABAN,SOLUONG,NGAYTAO,TAOBOI,NGAYSUA,SUABOI,NOIBAT,LUOTXEM,TINHTRANG")] HANGHOA hANGHOA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hANGHOA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MALOAI = new SelectList(db.LOAIHANGs, "MALOAI", "TENLOAI", hANGHOA.MALOAI);
            ViewBag.MAU = new SelectList(db.MAUSACs, "MAMAU", "NHAN", hANGHOA.MAU);
            return View(hANGHOA);
        }

        // GET: Admin/HANGHOAs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HANGHOA hANGHOA = db.HANGHOAs.Find(id);
            if (hANGHOA == null)
            {
                return HttpNotFound();
            }
            return View(hANGHOA);
        }

        // POST: Admin/HANGHOAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HANGHOA hANGHOA = db.HANGHOAs.Find(id);
            db.HANGHOAs.Remove(hANGHOA);
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
