namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIHANG")]
    public partial class LOAIHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIHANG()
        {
            HANGHOAs = new HashSet<HANGHOA>();
        }

        [Key]
        [StringLength(100)]
        public string MALOAI { get; set; }

        [StringLength(100)]
        public string TENLOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HANGHOA> HANGHOAs { get; set; }
    }
}
