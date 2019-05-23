namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETNHOMQUYEN")]
    public partial class CHITIETNHOMQUYEN
    {
        [Key]
        [StringLength(50)]
        public string TENDANGNHAP { get; set; }

        [StringLength(100)]
        public string MANHOM { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }

        public virtual NHOMQUYEN NHOMQUYEN { get; set; }
    }
}
