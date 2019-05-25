namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDAT")]
    public partial class PHIEUDAT
    {
        [Key]
        [StringLength(100)]
        public string MAPHIEUDAT { get; set; }

        [StringLength(100)]
        public string MANCC { get; set; }

        [StringLength(100)]
        public string MANV { get; set; }

        public DateTime? NGAYDAT { get; set; }

        public double? TONGTIEN { get; set; }

        [StringLength(10)]
        public string TINHTRANG { get; set; }

        public virtual CT_PHIEUDAT CT_PHIEUDAT { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
