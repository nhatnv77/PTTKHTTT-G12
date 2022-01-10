using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using QLTV.DAO;
using QLTV.Entity;
using QLTV.Util;

namespace QLTV.GUI
{
    public partial class frmTheLoai : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private bool option; // true: thêm; false: sửa

        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            bdsTheLoai.DataSource = Data.Instance.TheLoai.ToList();
            ChangeModeUpdate(false);
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeModeUpdate(bool isUpdating)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgt.Enabled = !isUpdating;
            btnXoa.Enabled = btnSua.Enabled = !isUpdating && (bdsTheLoai.Count > 0);
            btnGhi.Enabled = btnHuy.Enabled = isUpdating;
            gcKhu.Enabled = !isUpdating;
            groupKhu.Enabled = isUpdating;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsTheLoai.Position;
            option = true;
            bdsTheLoai.AddNew();
            ChangeModeUpdate(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maTheLoai = txtMaTheLoai.Text.Trim();
            string tenTheLoai = txtTenTheLoai.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            if (string.IsNullOrEmpty(maTheLoai))
            {
                XDialog.Error("Bạn chưa nhập mã thể loại!");
                txtMaTheLoai.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tenTheLoai))
            {
                XDialog.Error("Bạn chưa nhập tên thể loại!");
                txtTenTheLoai.Focus();
                return;
            }

            if (option)
            {
                TheLoai khu = new TheLoai()
                {
                    MaTheLoai = maTheLoai,
                    TenTheLoai = tenTheLoai,
                    MoTa = moTa
                };
                Data.Instance.TheLoai.Add(khu);
            }
            else
            {
                TheLoai theLoai = Data.Instance.TheLoai.Find(maTheLoai);
                theLoai.TenTheLoai = tenTheLoai;
                theLoai.MoTa = moTa;
            }
            Data.Instance.SaveChanges();
            LoadData();
            XDialog.Inform("Đã lưu thông tin thể loại vào cơ sở dữ liệu!");
            ChangeModeUpdate(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTheLoai.CancelEdit();
            bdsTheLoai.Position = position;
            if (!option)
            {
                txtMaTheLoai.Properties.ReadOnly = false;
            }
            ChangeModeUpdate(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsTheLoai.Position;
            option = false;
            txtMaTheLoai.Properties.ReadOnly = true;
            ChangeModeUpdate(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XDialog.Confirm("Bạn có chắc muốn xóa thể loại này không?") != DialogResult.OK)
            {
                return;
            }
            string maTheLoai = txtMaTheLoai.Text.Trim();
            Data.Instance.TheLoai.Remove(Data.Instance.TheLoai.Find(maTheLoai));
            Data.Instance.SaveChanges();
            LoadData();
        }
    }
}