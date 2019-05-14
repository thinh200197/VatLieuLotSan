namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOADON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MAHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAHANG { get; set; }

        public double? DONGIA { get; set; }

        public double? THANHTIEN { get; set; }

        public int? SOLUONG { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
