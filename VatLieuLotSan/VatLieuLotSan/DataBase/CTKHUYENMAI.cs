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
        [StringLength(10)]
        public string MAKM { get; set; }

        [Required]
        [StringLength(10)]
        public string MAHANG { get; set; }

        [Required]
        [StringLength(10)]
        public string MAMAU { get; set; }

        [StringLength(10)]
        public string SANPHAMTANG { get; set; }

        [StringLength(10)]
        public string SOLUONG { get; set; }

        public double? GIABANGIAM { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual KHUYENMAI KHUYENMAI { get; set; }
    }
}
