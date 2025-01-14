﻿namespace QuanLyTrungTamTiemChung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAP")]
    public partial class PHIEUNHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAP()
        {
            LOVACXIN = new HashSet<LOVACXIN>();
        }

        public PHIEUNHAP(PHIEUNHAP phieunhap)
        {
            MAPN = phieunhap.MAPN;
            NGAYNHAP = phieunhap.NGAYNHAP;
            TONGTIEN = phieunhap.TONGTIEN;
            MANSX = phieunhap.MANSX;
            MANV = phieunhap.MANV;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Mã phiếu nhập")]
        public int MAPN { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày nhập")]
        [Required(ErrorMessage = "Vui lòng nhập ngày nhập")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? NGAYNHAP { get; set; }

        [Display(Name = "Tổng tiền")]
        [Range(0, int.MaxValue, ErrorMessage = "Vui lòng nhập giá trị lớn hơn 0")]
        public decimal? TONGTIEN { get; set; }

        [Display(Name = "Nhà sản xuất")]
        [Required(ErrorMessage = "Vui lòng chọn nhà sản xuất")]
        public int? MANSX { get; set; }

        [Display(Name = "Nhân viên")]
        [Required(ErrorMessage = "Vui lòng chọn nhân viên")]
        public int? MANV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOVACXIN> LOVACXIN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual NHASANXUAT NHASANXUAT { get; set; }

        public IEnumerable<NHANVIEN> NHANVIENs { get; set; }

        public IEnumerable<NHASANXUAT> NHASANXUATs { get; set; }
    }
}
