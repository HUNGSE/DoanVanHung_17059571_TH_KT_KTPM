using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDoiBong_CodeFirst;
using Entities;

namespace DLL
{
    public class doibongDLL
    {
        public int ThemDoiBong(edoibong edb)
        {
            using (var db = new QuanLyDoiBongDBContext())
            {
                doibong doibong = db.Doibongs.Where(c => c.MaDoiBong.Equals(edb.MaDoiBong)).FirstOrDefault();
                if (doibong != null)
                {
                    return 0;
                }
                else
                {
                    doibong dbong = new doibong();
                    dbong.MaDoiBong = edb.MaDoiBong;
                    dbong.TenDoiBong = edb.TenDoiBong;
                    db.Doibongs.Add(dbong);
                    db.SaveChanges();
                    return 1;
                }
            }
        }

        public int SuaDoiBong(edoibong edb)
        {
            using (var db = new QuanLyDoiBongDBContext())
            {
                doibong doibong = db.Doibongs.Where(c => c.MaDoiBong.Equals(edb.MaDoiBong)).FirstOrDefault();
                if (doibong != null)
                {
                    doibong.MaDoiBong = edb.MaDoiBong;
                    doibong.TenDoiBong = edb.TenDoiBong;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int XoaDoiBong(edoibong edb)
        {
            using (var db = new QuanLyDoiBongDBContext())
            {
                doibong doibong = db.Doibongs.Where(c => c.MaDoiBong.Equals(edb.MaDoiBong)).FirstOrDefault();
                if (doibong != null)
                {
                    db.Doibongs.Remove(doibong);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public List<edoibong> LayDanhSachDoiBong()
        {
            List<edoibong> lst = new List<edoibong>();
            using (var db = new QuanLyDoiBongDBContext())
            {
                var doibongs = db.Doibongs.ToList();
                foreach (var doibong in doibongs)
                {
                    edoibong eDB = new edoibong();
                    eDB.MaDoiBong = doibong.MaDoiBong;
                    eDB.TenDoiBong = doibong.TenDoiBong;
                    lst.Add(eDB);
                }
            }
            return lst;
        }

        public edoibong LayDoiBongTheoTen(string ten)
        {
            edoibong edb = new edoibong();
            using (var db = new QuanLyDoiBongDBContext())
            {
                var doibong = db.Doibongs.Where(c => c.TenDoiBong.Equals(ten)).FirstOrDefault();
                if (doibong != null)
                {
                    edb.MaDoiBong = doibong.MaDoiBong;
                    edb.TenDoiBong = doibong.TenDoiBong;
                }
            }
            return edb;
        }
    }
}
