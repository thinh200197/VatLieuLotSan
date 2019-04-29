namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIDUNG")]
    public partial class NGUOIDUNG
    {
        [Key]
        [StringLength(50)]
        public string TENDANGNHAP { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(30)]
        public string MATKHAU { get; set; }

        public DateTime? NGAYTAO { get; set; }

        [StringLength(50)]
        public string TAOBOI { get; set; }

        public DateTime? NGAYSUA { get; set; }

        [StringLength(50)]
        public string SUABOI { get; set; }

        [StringLength(10)]
        public string HOATDONG { get; set; }

        public virtual CHITIETNHOMQUYEN CHITIETNHOMQUYEN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
