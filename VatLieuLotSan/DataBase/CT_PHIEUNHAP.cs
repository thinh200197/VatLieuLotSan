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
        [Column(Order = 0)]
        [StringLength(100)]
        public string MAPHIEUNHAP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string MAHANG { get; set; }

        [Required]
        [StringLength(100)]
        public string MAMAU { get; set; }

        public int? SOLUONG { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }
    }
}
