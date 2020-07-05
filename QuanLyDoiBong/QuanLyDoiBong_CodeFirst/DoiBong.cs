using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong_CodeFirst
{
    public class doibong
    {
        public doibong()
        {
            Cauthus = new HashSet<cauthu>();
        }

        [Key]
        public string MaDoiBong { get; set; }

        public string TenDoiBong { get; set; }

        public virtual ICollection<cauthu> Cauthus { get; set; }
    }
}
