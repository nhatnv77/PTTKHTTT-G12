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
    public partial class frmDocGia : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private bool option; // true: thêm; false: sửa

        public frmDocGia()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            bdsDocGia.DataSource = Data.Instance.DocGia.ToList();
            ChangeModeUpdate(false);
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeModeUpdate(bool isUpdating)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgt.Enabled = !isUpdating;
            btnXoa.Enabled = btnSua.Enabled = !isUpdating && (bdsDocGia.Count > 0);
            btnGhi.Enabled = btnHuy.Enabled = isUpdating;
            gcKho.Enabled = !isUpdating;
            groupDocGia.Enabled = isUpdating;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsDocGia.Position;
            option = true;
            bdsDocGia.AddNew();
            txtMaDocGia.Text = CodeGenerator.SinhMaDocGia();
            bdsDocGia.EndEdit();
            ChangeModeUpdate(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maDocGia = txtMaDocGia.Text.Trim();
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();
            string mssv = txtMSSV.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(ho))
            {
                XDialog.Error("Bạn chưa nhập họ của độc giả!");
                txtHo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ten))
            {
                XDialog.Error("Bạn chưa nhập tên của độc giả!");
                txtTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty(mssv))
            {
                XDialog.Error("Bạn chưa nhập mã số sinh viên của độc giả!");
                txtMSSV.Focus();
                return;
            }

            if (option)
            {
                DocGia dg = new DocGia()
                {
                    MaDG = maDocGia,
                    Ho = ho,
                    Ten = ten,
                    MSSV = mssv,
                    SDT = sdt,
                    Email = email,
                };
                Data.Instance.DocGia.Add(dg);
            }
            else
            {
                DocGia dg = Data.Instance.DocGia.Find(maDocGia);
                dg.Ho = ho;
                dg.Ten = ten;
                dg.MSSV = mssv;
                dg.SDT = sdt;
                dg.Email = email;
            }
            Data.Instance.SaveChanges();
            LoadData();
            XDialog.Inform("Đã lưu thông tin độc giả vào cơ sở dữ liệu!");
            ChangeModeUpdate(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (option)
            {
                bdsDocGia.RemoveCurrent();
            }
            bdsDocGia.Position = position;
            ChangeModeUpdate(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsDocGia.Position;
            option = false;
            ChangeModeUpdate(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maDG = txtMaDocGia.Text.Trim();
            DocGia dg = Data.Instance.DocGia.Find(maDG);
            if (dg.TaiKhoanDG.Count > 0)
            {
                XDialog.Error("Không thể xóa độc giả này vì độc giả này có tài khoản trong hệ thống!");
                return;
            }
            if (dg.TheDocGia.Count > 0)
            {
                XDialog.Error("Không thể xóa độc giả này vì độc giả này đã có thẻ độc giả!");
                return;
            }
            if (XDialog.Confirm("Bạn có chắc muốn xóa độc giả này không?") != DialogResult.OK)
            {
                return;
            }
            try
            {
                Data.Instance.DocGia.Remove(dg);
                Data.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                XDialog.Error("Đã có lỗi xảy ra khi xóa độc giả!\n" + ex.Message);
                return;
            }
            LoadData();
        }
    }
}