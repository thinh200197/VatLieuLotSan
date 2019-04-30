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
        [StringLength(10)]
        public string MAHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MAHANG { get; set; }

        [Required]
        [StringLength(10)]
        public string MAMAU { get; set; }

        [Key]
        [StringLength(10)]
        public string MAPHIEUGIAO { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual PHIEUGIAO PHIEUGIAO { get; set; }
    }
}