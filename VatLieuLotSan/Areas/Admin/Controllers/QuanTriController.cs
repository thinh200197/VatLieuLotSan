using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VatLieuLotSan.Areas.Admin.Controllers
{
    public class QuanTriController : BaseController
    {
        // GET: Admin/QuanTri
        public ActionResult Index()
        {
            return View();
        }
    }
}