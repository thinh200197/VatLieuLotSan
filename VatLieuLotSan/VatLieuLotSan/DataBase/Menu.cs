namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TenMenu { get; set; }

        public int? LoaiMenu { get; set; }

        [StringLength(250)]
        public string Link { get; set; }

        public bool? TrangThai { get; set; }
    }
}
