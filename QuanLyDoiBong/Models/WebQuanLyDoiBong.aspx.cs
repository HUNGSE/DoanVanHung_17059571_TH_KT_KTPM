using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DLL;
using Entities;

namespace QuanLyDoiBong.Models
{
    public partial class WebQuanLyDoiBong : System.Web.UI.Page
    {
        List<edoibong> doibongs;
        List<ecauthu> cauthus;
        string maDB;

        protected void Page_Load(object sender, EventArgs e)
        {
            doibongs = new doibongDLL().LayDanhSachDoiBong();//.Where(c => c.MaDoiBong.Equals("HN")).ToList();
            //cboDoiBong.Items.Clear();
            loadDataComboBox(doibongs);
        }

        void loadDataComboBox(List<edoibong> doibongs)
        {
            //cboDoiBong.Items.Clear();
            foreach (var db in doibongs)
            {
                ListItem it = new ListItem(db.TenDoiBong, db.MaDoiBong);
                cboDoiBong.Items.Add(it);
            }
            
            //cboDoiBong.DataSource = doibongs;
            //cboDoiBong.DataTextField = "TenDoiBong";
            //cboDoiBong.DataValueField = "MaDoiBong";
            //cboDoiBong.DataBind();
        }

        protected void btnHienThi_Click(object sender, EventArgs e)
        {
            maDB = cboDoiBong.SelectedValue;
            cauthus = new cauthuDLL().LayDanhSachCauThuThuocDoiBong(maDB);
            loadDataDataGrid(cauthus);

            doibongs = new doibongDLL().LayDanhSachDoiBong();
            cboDoiBong.Items.Clear();
            loadDataComboBox(doibongs);
            cboDoiBong.Text = maDB;
        }

        void loadDataDataGrid(List<ecauthu> cauthus)
        {
            if (cauthus.Count > 0)
            {
                DGVCauThu.DataSource = cauthus;
                DGVCauThu.DataBind();
            }
            else
            {
                DGVCauThu.Visible = false;
            }
        }

        protected void DGVCauThu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lnkselect_Click(object sender, EventArgs e)
        {
            cauthus = new cauthuDLL().LayDanhSachCauThuThuocDoiBong(cboDoiBong.SelectedValue);
            ecauthu ct = cauthus.Where(c => c.MaCauThu.Equals(Convert.ToString((sender as LinkButton).CommandArgument))).FirstOrDefault();
            if (ct != null)
            {
                tbxMaCauThu.Text = ct.MaCauThu;
                tbxTenCauThu.Text = ct.TenCauThu;
                tbxEmail.Text = ct.Email;
                tbxSoDT.Text = ct.Sodt;
                tbxMaDoiBong.Text = ct.IdDoiBong;
            }
        }
    }
}