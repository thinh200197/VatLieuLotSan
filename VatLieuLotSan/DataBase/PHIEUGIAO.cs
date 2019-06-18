namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUGIAO")]
    public partial class PHIEUGIAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUGIAO()
        {
            CTPHIEUGIAOs = new HashSet<CTPHIEUGIAO>();
        }

        [Key]
        [StringLength(100)]
        public string MAPHIEUGIAO { get; set; }

        [StringLength(100)]
        public string MAHD { get; set; }

        public DateTime? NGAYGIAO { get; set; }

        [StringLength(250)]
        public string DIACHIGIAO { get; set; }

        [StringLength(100)]
        public string MANV { get; set; }

        [StringLength(10)]
        public string SDTNV { get; set; }

        [StringLength(10)]
        public string TINHTRANG { get; set; }

        [StringLength(100)]
        public string NGUOINHAN { get; set; }

        [StringLength(10)]
        public string SDTKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUGIAO> CTPHIEUGIAOs { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
