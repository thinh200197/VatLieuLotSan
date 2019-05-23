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
        [Required]
        [StringLength(100)]
        public string MAHD { get; set; }

        [Required]
        [StringLength(100)]
        public string MAHANG { get; set; }

        public int? SOLUONG { get; set; }

        [Required]
        [StringLength(100)]
        public string MAMAU { get; set; }

        [Key]
        [StringLength(100)]
        public string MAPHIEUGIAO { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual PHIEUGIAO PHIEUGIAO { get; set; }
    }
}
