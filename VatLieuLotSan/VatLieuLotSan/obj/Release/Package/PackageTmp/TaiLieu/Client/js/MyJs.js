﻿var GioHang = {
    init: function () {
        GioHang.regEvents();
    },
    regEvents: function () {
        $('#btn_TiepTucMuaHang').off('click').on('click', function () {
            window.location.href = "/san-pham";
        });

        $('.btn-Xoa').off('click').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                data: { MaHang: $(this).data('id') },
                url: '/GioHang/Xoa1SP',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = '/gio-hang';
                    }
                }
            });
        });

        $('#btn_XoaGioHang').off('click').on('click', function (e) {
            e.preventDefault();
            $.ajax({

                url: '/GioHang/XoaHetSP',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = '/gio-hang';
                    }
                }
            });
        });

        $('#btn_CapNhatGioHang').off('click').on('click', function () {
            var listSP = $('.txtSoLuong');
            var GioHang = [];
            $.each(listSP, function (i, item) {
                // phải điền các biến giống với mà ta đã thiết lập bên GioHangModel
                GioHang.push({
                    SoLuong: $(item).val(),
                    SanPham: {
                        MAHANG: $(item).data('id')
                    }
                });
            });
            $.ajax({
                url: '/GioHang/CapNhatHang',
                data: { giohangModel: JSON.stringify(GioHang) },
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = '/gio-hang';
                    }
                }
            });
        });

        $('.btn_ThemVaoGioHang').off('click').on('click', function () {
            var pid = $(this).data('id');
            var soLuong = 1;
            var urlNow = $('#txt-MaHang').data('id');
            $.ajax(
                {
                    url: "/GioHang/ThemSPVaoGio",
                    data: { MaHang: pid, SoLuong: soLuong, Url: urlNow },
                    dataType: 'json',
                    type:'POST',
                    success: function(res)
                    {
                        if (res.status == true)
                        {
                            //window.location.href = res.link;
                            console.log()
                        }
                    }
                });
        });
    }

}
GioHang.init();