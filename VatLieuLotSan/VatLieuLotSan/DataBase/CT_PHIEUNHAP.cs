namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUNHAP
    {
        [Key]
        [StringLength(10)]
        public string MAPHIEUNHAP { get; set; }

        [Required]
        [StringLength(10)]
        public string MAPHIEUDAT { get; set; }

        [Required]
        [StringLength(10)]
        public string MAHANG { get; set; }

        [Required]
        [StringLength(10)]
        public string MAMAU { get; set; }

        public int? SOLUONG { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual PHIEUNHAP PHIEUNHAP { get; set; }
    }
}
