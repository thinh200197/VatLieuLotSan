namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIKHACHHANG")]
    public partial class LOAIKHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIKHACHHANG()
        {
            KHACHHANGs = new HashSet<KHACHHANG>();
        }

        [Key]
        [StringLength(10)]
        public string MALOAI { get; set; }

        [StringLength(30)]
        public string TENLOAN { get; set; }

        [StringLength(100)]
        public string NHAN { get; set; }

        public double? MUCGIAM { get; set; }

        public int? GIOIHANGDIEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
    }
}
