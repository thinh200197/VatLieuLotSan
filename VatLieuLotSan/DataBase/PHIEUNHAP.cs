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
        [StringLength(100)]
        public string MAPHIEUNHAP { get; set; }

        [Required]
        [StringLength(100)]
        public string MAPHIEUDAT { get; set; }

        [StringLength(100)]
        public string MANCC { get; set; }

        [StringLength(100)]
        public string MANV { get; set; }

        public DateTime? NGAYNHAP { get; set; }

        public double? TONGTIEN { get; set; }

        [StringLength(10)]
        public string TINHTRANG { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
