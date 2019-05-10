﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VatLieuLotSan.Models;

namespace VatLieuLotSan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new SanPhamModel();
            ViewBag.NoiBat = model.SanPhamNoiBat();
            ViewBag.LuotXem = model.SanPhamLuotXem();
            ViewBag.ChuaRaMat = model.SanPhamSapRaMat();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HeaderDesktop()
        {
            var model = new MenuModel();
             var menu = model.DanhMuc(1);
            return PartialView(menu);
        }

        public PartialViewResult HeaderIconCart()
        {
            var model = new GioHangModel();
            var lstProduct = (List<GioHangModel>)Session[Common.CommonConstants.GioHangSession];
            if (lstProduct == null)
            {
                return PartialView();
            }
            return PartialView(lstProduct);
        }
    }
}