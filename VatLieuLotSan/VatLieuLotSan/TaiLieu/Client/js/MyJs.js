var GioHang = {
    init: function () {
        GioHang.regEvents();
    },
    regEvents: function () {
        $('#btn_TiepTucMuaHang').off('click').on('click', function () {
            window.location.href = "/san-pham";
        });
        $('#btn_XoaGioHang').off('click').on('click', function () {
            window.location.href = "/san-pham";
        });
        $('#btn_CapNhatGioHang').off('click').on('click', function () {
            window.location.href = "/san-pham";
        });
        $('.btn_ThemVaoGioHang').off('click').on('click', function () {
            var pid = $(this).attr("data-id");
            var soLuong = 1;
            var urlNow = $(this).attr("data-Url");
            $.ajax({
                url: "/GioHang/ThemVaoGioHang",
                data: { MaHang: pid, SoLuong: soLuong, Url: urlNow },
                success: function(reg)
                {
                    alert("Thêm thành công");
                }

            });
        });
    }

}
GioHang.init();