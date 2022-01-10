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
    public partial class frmKe : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private bool option; // true: thêm; false: sửa

        public frmKe()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            bdsKhu.DataSource = Data.Instance.Khu.ToList();
            if (lkKhu.EditValue != null)
            {
                string maKhu = lkKhu.EditValue.ToString();
                bdsKeSach.DataSource = Data.Instance.KeSach.Where(k => k.MaKhu == maKhu).ToList();
            }
            ChangeModeUpdate(false);
        }

        private void frmKe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeModeUpdate(bool isUpdating)
        {
            btnThem.Enabled = !(lkKhu.EditValue == null || isUpdating);
            btnReload.Enabled = btnThoat.Enabled = nvgt.Enabled = !isUpdating;
            btnXoa.Enabled = btnSua.Enabled = !isUpdating && (bdsKeSach.Count > 0);
            btnGhi.Enabled = btnHuy.Enabled = isUpdating;
            gcKeSach.Enabled = !isUpdating;
            groupKeSach.Enabled = isUpdating;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsKeSach.Position;
            option = true;
            bdsKeSach.AddNew();
            txtMaKe.Properties.ReadOnly = false;
            ChangeModeUpdate(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKe = txtMaKe.Text.Trim();
            string tenKe = txtTenKe.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            bool trangThai = ckTrangThai.Checked;
            string maKhu = lkKhu.EditValue.ToString();

            if (string.IsNullOrEmpty(maKe))
            {
                XDialog.Error("Bạn chưa nhập mã kệ!");
                txtMaKe.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tenKe))
            {
                XDialog.Error("Bạn chưa nhập tên kệ!");
                txtTenKe.Focus();
                return;
            }

            if (option)
            {
                KeSach ke = new KeSach()
                {
                    MaKe = maKe,
                    TenKe = tenKe,
                    MoTa = moTa,
                    TrangThai = trangThai,
                    MaKhu = maKhu
                };
                Data.Instance.KeSach.Add(ke);
            }
            else
            {
                KeSach ke = Data.Instance.KeSach.Find(maKe);
                ke.TenKe = tenKe;
                ke.MoTa = moTa;
                ke.TrangThai = trangThai;
            }
            Data.Instance.SaveChanges();
            LoadData();
            XDialog.Inform("Đã lưu thông tin kệ sách vào cơ sở dữ liệu!");
            ChangeModeUpdate(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKeSach.CancelEdit();
            bdsKeSach.Position = position;
            ChangeModeUpdate(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsKeSach.Position;
            option = false;
            txtMaKe.Properties.ReadOnly = true;
            ChangeModeUpdate(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XDialog.Confirm("Bạn có chắc muốn xóa kệ sách này không?") != DialogResult.OK)
            {
                return;
            }
            string maKe = txtMaKe.Text.Trim();
            Data.Instance.KeSach.Remove(Data.Instance.KeSach.Find(maKe));
            Data.Instance.SaveChanges();
            LoadData();
        }

        private void lkKhu_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}