namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUGIAO")]
    public partial class PHIEUGIAO
    {
        [Key]
        [StringLength(10)]
        public string MAPHIEUGIAO { get; set; }

        [StringLength(10)]
        public string MAHD { get; set; }

        public DateTime? NGAYGIAO { get; set; }

        [StringLength(100)]
        public string DIACHIGIAO { get; set; }

        [StringLength(10)]
        public string NGUOIGIAO { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(10)]
        public string TINHTRANG { get; set; }

        [StringLength(50)]
        public string NGUOINHAN { get; set; }

        public DateTime? NGAYTAO { get; set; }

        [StringLength(50)]
        public string TAOBOI { get; set; }

        public DateTime? NGAYSUA { get; set; }

        [StringLength(50)]
        public string SUABOI { get; set; }

        [StringLength(10)]
        public string SODIENTHOAI { get; set; }

        public virtual CTPHIEUGIAO CTPHIEUGIAO { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
