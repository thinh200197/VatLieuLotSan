namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUYENMAI")]
    public partial class KHUYENMAI
    {
        [Key]
        [StringLength(100)]
        public string MAKM { get; set; }

        [StringLength(100)]
        public string TENKM { get; set; }

        public DateTime? NGAYBATDAU { get; set; }

        public DateTime? NGAYKETTHUC { get; set; }

        [StringLength(100)]
        public string HINHTHUCKM { get; set; }

        public virtual CTKHUYENMAI CTKHUYENMAI { get; set; }
    }
}
