using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class DiemThi
    {
        [Key]
        [Required, MaxLength(20)]
        public string MaSV { get; set; }
        [Required, MaxLength(20)]
        public string MaMH { get; set; }
        [Required, MaxLength(30)]
        public string KetQua { get; set; }
        public int LanThi { get; set; }
        [ForeignKey ("MaSV")]
        public SinhVien sinhVien { get; set; }

    }
}