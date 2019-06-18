namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTKHUYENMAI")]
    public partial class CTKHUYENMAI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string MAKM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string MAHANG { get; set; }

        [Required]
        [StringLength(100)]
        public string MAMAU { get; set; }

        [StringLength(100)]
        public string SANPHAMTANG { get; set; }

        public int? SOLUONG { get; set; }

        public double? GIABANGIAM { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual KHUYENMAI KHUYENMAI { get; set; }
    }
}
