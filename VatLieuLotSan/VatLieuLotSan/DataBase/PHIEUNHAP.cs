namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAP")]
    public partial class PHIEUNHAP
    {
        [Key]
        [StringLength(10)]
        public string MAPHIEUNHAP { get; set; }

        [StringLength(10)]
        public string MANCC { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        public DateTime? NGAYNHAP { get; set; }

        public double? TONGTIEN { get; set; }

        [StringLength(10)]
        public string TINHTRANG { get; set; }

        public virtual CT_PHIEUNHAP CT_PHIEUNHAP { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
