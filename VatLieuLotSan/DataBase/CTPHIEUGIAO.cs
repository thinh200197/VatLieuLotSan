namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPHIEUGIAO")]
    public partial class CTPHIEUGIAO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string MAPHIEUGIAO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string MAHANG { get; set; }

        [Required]
        [StringLength(100)]
        public string MAMAU { get; set; }

        public double? DONGIA { get; set; }

        public int? SOLUONG { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual PHIEUGIAO PHIEUGIAO { get; set; }
    }
}
