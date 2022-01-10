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
    public partial class frmKhu : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private bool option; // true: thêm; false: sửa

        public frmKhu()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            bdsKhu.DataSource = Data.Instance.Khu.ToList();
            ChangeModeUpdate(false);
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeModeUpdate(bool isUpdating)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgt.Enabled = !isUpdating;
            btnXoa.Enabled = btnSua.Enabled = !isUpdating && (bdsKhu.Count > 0);
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
            position = bdsKhu.Position;
            option = true;
            bdsKhu.AddNew();
            ChangeModeUpdate(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKhu = txtMaKhu.Text.Trim();
            string tenKhu = txtTenKhu.Text.Trim();
            string viTri = txtViTri.Text.Trim();
            bool trangThai = ckTrangThai.Checked;

            if (string.IsNullOrEmpty(maKhu))
            {
                XDialog.Error("Bạn chưa nhập mã khu!");
                txtMaKhu.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tenKhu))
            {
                XDialog.Error("Bạn chưa nhập tên khu!");
                txtTenKhu.Focus();
                return;
            }

            if (option)
            {
                Khu khu = new Khu()
                {
                    MaKhu = maKhu,
                    TenKhu = tenKhu,
                    ViTri = viTri,
                    TrangThai = trangThai
                };
                Data.Instance.Khu.Add(khu);
            }
            else
            {
                Khu khu = Data.Instance.Khu.Find(maKhu);
                khu.TenKhu = tenKhu;
                khu.ViTri = viTri;
                khu.TrangThai = trangThai;
            }
            Data.Instance.SaveChanges();
            LoadData();
            XDialog.Inform("Đã lưu thông tin khu vào cơ sở dữ liệu!");
            ChangeModeUpdate(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhu.CancelEdit();
            bdsKhu.Position = position;
            if (!option)
            {
                txtMaKhu.Properties.ReadOnly = false;
            }
            ChangeModeUpdate(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsKhu.Position;
            option = false;
            txtMaKhu.Properties.ReadOnly = true;
            ChangeModeUpdate(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XDialog.Confirm("Bạn có chắc muốn xóa khu này không?") != DialogResult.OK)
            {
                return;
            }
            string maKhu = txtMaKhu.Text.Trim();
            Data.Instance.Khu.Remove(Data.Instance.Khu.Find(maKhu));
            Data.Instance.SaveChanges();
            LoadData();
        }
    }
}