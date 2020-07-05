using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDoiBong_CodeFirst;
using Entities;

namespace DLL
{
    public class cauthuDLL
    {
        public int ThemCauThu(ecauthu ct)
        {
            using(var db = new QuanLyDoiBongDBContext())
            {
                cauthu cauthu = db.Cauthus.Where(c => c.MaCauThu.Equals(ct.MaCauThu)).FirstOrDefault();
                if (cauthu != null)
                {
                    return 0;
                }
                else
                {
                    cauthu caut = new cauthu();
                    caut.MaCauThu = ct.MaCauThu;
                    caut.TenCauThu = ct.TenCauThu;
                    caut.Sodt = ct.Sodt;
                    caut.Email = ct.Email;
                    caut.IdDoiBong = ct.IdDoiBong;
                    db.Cauthus.Add(caut);
                    db.SaveChanges();
                    return 1;
                }
            }
        }

        public int SuaCauThu(ecauthu ct)
        {
            using (var db = new QuanLyDoiBongDBContext())
            {
                cauthu cauthu = db.Cauthus.Where(c => c.MaCauThu.Equals(ct.MaCauThu)).FirstOrDefault();
                if (cauthu != null)
                {
                    cauthu.MaCauThu = ct.MaCauThu;
                    cauthu.TenCauThu = ct.TenCauThu;
                    cauthu.Sodt = ct.Sodt;
                    cauthu.Email = ct.Email;
                    cauthu.IdDoiBong = ct.IdDoiBong;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int XoaCauThu(ecauthu ct)
        {
            using (var db = new QuanLyDoiBongDBContext())
            {
                cauthu cauthu = db.Cauthus.Where(c => c.MaCauThu.Equals(ct.MaCauThu)).FirstOrDefault();
                if (cauthu != null)
                {
                    db.Cauthus.Remove(cauthu);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public ecauthu TimTheoMa(string macauthu)
        {
            using (var db = new QuanLyDoiBongDBContext())
            {
                cauthu cauthu = db.Cauthus.Where(c => c.MaCauThu.Equals(macauthu)).FirstOrDefault();
                if (cauthu != null)
                {
                    ecauthu eCT = new ecauthu();
                    eCT.MaCauThu=cauthu.MaCauThu;
                    eCT.TenCauThu=cauthu.TenCauThu;
                    eCT.Sodt=cauthu.Sodt;
                    eCT.Email=cauthu.Email;
                    eCT.IdDoiBong=cauthu.IdDoiBong;
                    return eCT;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<ecauthu> LayDanhSachCauThuThuocDoiBong(string maDoiBong)
        {
            List<ecauthu> lst = new List<ecauthu>();
            using (var db = new QuanLyDoiBongDBContext())
            {
                var cauthus = db.Cauthus.Where(c=>c.IdDoiBong.Equals(maDoiBong)).ToList();
                foreach (var cauthu in cauthus)
                {
                    ecauthu eCT = new ecauthu();
                    eCT.MaCauThu = cauthu.MaCauThu;
                    eCT.TenCauThu = cauthu.TenCauThu;
                    eCT.Sodt = cauthu.Sodt;
                    eCT.Email = cauthu.Email;
                    eCT.IdDoiBong = cauthu.IdDoiBong;
                    lst.Add(eCT);
                }
            }
            return lst;
        }
    }
}
