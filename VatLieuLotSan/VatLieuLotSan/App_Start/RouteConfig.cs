using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VatLieuLotSan
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Trang chủ",
                url: "trang-chu",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "VatLieuLotSan.Controllers" }
            );

            routes.MapRoute(
              name: "Trang Sản phẩm",
              url: "san-pham",
              defaults: new { controller = "SanPham", action = "SanPham", id = UrlParameter.Optional },
              namespaces: new[] { "VatLieuLotSan.Controllers" }
              );


            routes.MapRoute(
              name: "Trang Sản phẩm theo loại",
              url: "san-pham/{Maloai}",
              defaults: new { controller = "SanPham", action = "XuatHangTheoLoai", id = UrlParameter.Optional },
              namespaces: new[] { "VatLieuLotSan.Controllers" }
              );

            routes.MapRoute(
              name: "Trang chi tiết sản phẩm",
              url: "chi-tiet-san-pham/{MaHang}",
              defaults: new { controller = "SanPham", action = "ChiTietSanPham", id = UrlParameter.Optional },
              namespaces: new[] { "VatLieuLotSan.Controllers" }
              );

            routes.MapRoute(
             name: "Thêm sản phẩm vào giỏ hàng",
             url: "them-san-pham-gio-hang/{MaHang,SoLuong,Url}",
             defaults: new { controller = "GioHang", action = "ThemVaoGioHang", id = UrlParameter.Optional },
             namespaces: new[] { "VatLieuLotSan.Controllers" }
             );

            routes.MapRoute(
             name: "Thêm vào giỏ",
             url: "them-vao-gio-hang",
             defaults: new { controller = "GioHang", action = "ThemVaoGioHang", id = UrlParameter.Optional },
             namespaces: new[] { "VatLieuLotSan.Controllers" }
             );
            routes.MapRoute(
              name: "Trang liên hệ",
              url: "lien-he",
              defaults: new { controller = "LienHe", action = "LienHe", id = UrlParameter.Optional },
              namespaces: new[] { "VatLieuLotSan.Controllers" }
              );

            routes.MapRoute(
                name: "Trang Giới thiệu",
                url: "gioi-thieu",
                defaults: new { controller = "GioiThieu", action = "GioiThieu", id = UrlParameter.Optional },
                namespaces: new[] { "VatLieuLotSan.Controllers" }
                );

            routes.MapRoute(
              name: "Trang Giỏ hàng",
              url: "gio-hang",
              defaults: new { controller = "GioHang", action = "GioHang", id = UrlParameter.Optional },
              namespaces: new[] { "VatLieuLotSan.Controllers" }
              );

            routes.MapRoute(
              name: "Trang Thanh Toán",
              url: "dat-hang",
              defaults: new { controller = "GioHang", action = "DatHang", id = UrlParameter.Optional },
              namespaces: new[] { "VatLieuLotSan.Controllers" }
              );

            routes.MapRoute(
             name: "Đặt thành công",
             url: "hoan-thanh",
             defaults: new { controller = "GioHang", action = "HoanThanh", id = UrlParameter.Optional },
             namespaces: new[] { "VatLieuLotSan.Controllers" }
             );

         

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "VatLieuLotSan.Controllers" }
              );
        }
    }
}
