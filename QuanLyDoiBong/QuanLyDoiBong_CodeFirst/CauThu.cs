using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyDoiBong_CodeFirst
{
    public class cauthu
    {
        [Key]
        public string MaCauThu { get; set; }

        public string TenCauThu { get; set; }

        public string Sodt { get; set; }

        public string Email { get; set; }

        public string IdDoiBong { get; set; }

        public virtual doibong DoiBong { get; set; }
    }
}
