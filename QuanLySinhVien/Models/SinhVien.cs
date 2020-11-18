using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class SinhVien
    {
        [Key]
        [Required, MaxLength(20)]
        public string MaSV { get; set; }
        [Required, MaxLength(30)]
        public string TenSV { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        [Required, MaxLength(20)]
        public string MaLop { get; set; }
        public ICollection <DiemThi> DiemThis { get; set; }

    }
}