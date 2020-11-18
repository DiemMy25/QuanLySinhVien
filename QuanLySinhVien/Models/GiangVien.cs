using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class GiangVien
    {
        [Key]
        [Required, MaxLength(20)]
        public string MaGV { get; set; }
        [Required, MaxLength(20)]
        public string TenGV { get; set; }
        public int ChuyenNganh { get; set; }
        public int MaKhoa { get; set; }
    }
}