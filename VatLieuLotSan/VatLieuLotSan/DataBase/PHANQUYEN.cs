namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANQUYEN")]
    public partial class PHANQUYEN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string MAMH { get; set; }

        [StringLength(10)]
        public string TINIHTRANG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string MANHOM { get; set; }

        public virtual MANHINH MANHINH { get; set; }

        public virtual NHOMQUYEN NHOMQUYEN { get; set; }
    }
}
