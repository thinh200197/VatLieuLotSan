namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUDAT
    {
        [Key]
        [StringLength(100)]
        public string MAPHIEUDAT { get; set; }

        [Required]
        [StringLength(100)]
        public string MAHANG { get; set; }

        [Required]
        [StringLength(100)]
        public string MAMAU { get; set; }

        public int? SOLUONG { get; set; }

        public double? DONGIANHAP { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual PHIEUDAT PHIEUDAT { get; set; }
    }
}
