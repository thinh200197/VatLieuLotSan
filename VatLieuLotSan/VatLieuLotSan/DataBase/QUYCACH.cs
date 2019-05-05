namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUYCACH")]
    public partial class QUYCACH
    {
        [Key]
        [StringLength(10)]
        public string MAHH { get; set; }

        [StringLength(50)]
        public string KICHTHUOC { get; set; }

        public double? DienTichTam { get; set; }

        public int? TamTrenHop { get; set; }

        public int? TrongLuong { get; set; }

        [StringLength(100)]
        public string XuatXu { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }
    }
}
