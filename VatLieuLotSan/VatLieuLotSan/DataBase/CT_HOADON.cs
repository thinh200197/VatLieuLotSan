namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOADON
    {
        [Key]
        [StringLength(10)]
        public string MAHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MAHANG { get; set; }

        [Required]
        [StringLength(10)]
        public string MAMAU { get; set; }

        public int? SOLUONG { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
