namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTGIOHANG")]
    public partial class CTGIOHANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MAGIOHANG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAHANG { get; set; }

        public int? SOLUONG { get; set; }

        public double? DONGIA { get; set; }

        [StringLength(100)]
        public string GHICHU { get; set; }

        public double? THANHTIEN { get; set; }

        public virtual GIOHANG GIOHANG { get; set; }
    }
}
