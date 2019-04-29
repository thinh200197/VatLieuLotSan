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

        public DateTime? NGAYNHAP { get; set; }

        public double? TONGTIEN { get; set; }

        public DateTime? NGAYTAO { get; set; }

        [StringLength(50)]
        public string TAOBOI { get; set; }

        public DateTime? NGAYSUA { get; set; }

        [StringLength(50)]
        public string SUABOI { get; set; }

        [StringLength(10)]
        public string TINHTRANG { get; set; }

        public virtual CT_PHIEUNHAP CT_PHIEUNHAP { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
